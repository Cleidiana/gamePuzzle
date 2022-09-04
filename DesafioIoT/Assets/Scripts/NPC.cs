using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour {
    public int idMissao;
    private CircleCollider2D iniciarMissao;
    public Text missoes;
    private bool desativaMissao;
    // Use this for initialization
    private void Awake()
    {
        iniciarMissao = GetComponent<CircleCollider2D>();
        missoes.text = "";
        desativaMissao = false;
        
    }
    void Update() {
        if (!desativaMissao) {

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        Missao.instance.setObs(idMissao);
        
    }
}
