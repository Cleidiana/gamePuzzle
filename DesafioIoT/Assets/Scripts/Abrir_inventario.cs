using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Abrir_inventario : MonoBehaviour {
    public GameObject inventario;
    public GameObject botaoSair;
    private CircleCollider2D abrirInventario;

    private void Awake()
    {

        abrirInventario = GetComponent<CircleCollider2D>();
        inventario.SetActive(false);
        botaoSair.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Movimento_personagem.instance.SetVelocidade(0f);
        
        inventario.SetActive(true);
        botaoSair.SetActive(true);
    }
    public void SairInventario(GameObject Bt) {
        Movimento_personagem.instance.SetVelocidade(5f);
        inventario.SetActive(false);
        botaoSair.SetActive(false);
        
    }

}
