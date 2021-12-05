using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimento_personagem : MonoBehaviour
{
    private float vel = 5f;
    private Vector2 movimento;
    public Animator animacao;
    private Rigidbody2D playerRb;

    private SpriteRenderer playerR;

    private Vector2 direcaoPlayer;
    [SerializeField] //pra enxergar no espector
    private bool danoCritico = false;

    // Use this for initialization
    void Start()
    {
        movimento = Vector2.zero;
        playerRb = GetComponent<Rigidbody2D>();
        playerR = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {

        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");
        animacao.SetFloat("horizontal", movimento.x);
        animacao.SetFloat("vertical", movimento.y);
        animacao.SetFloat("velocidade", movimento.sqrMagnitude);

        if (movimento != Vector2.zero) {

            animacao.SetFloat("horizontal_parado", movimento.x);
            animacao.SetFloat("vertical_parado", movimento.y);
        }

        if (danoCritico == true)
        {
            PingPongColor(1);
        }

    }

    void PingPongColor(int x)
    {
        playerR.color = Color.Lerp(Color.white, Color.red, Mathf.PingPong(x * Time.time, 0.5f));

    }
    private void FixedUpdate()
    {

        playerRb.MovePosition(playerRb.position + movimento.normalized * vel * Time.fixedDeltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("eletrico"))
        {
            StartCoroutine(funcKnock(1f, 50, direcaoPlayer));
        }
    }
    public IEnumerator funcKnock(float duracao, float poder, Vector2 direcao)
    {
        float tempo = 0;

        while (duracao > tempo)
        {
            tempo += Time.deltaTime;
            playerRb.AddForce(new Vector2(direcao.x * -poder, direcao.y * -poder), ForceMode2D.Force);
        }
        yield return 0;

    }
}


