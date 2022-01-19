using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        print("oi");
        inventario.SetActive(true);
        botaoSair.SetActive(true);
    }
    public void SairInventario(GameObject Bt) {
        inventario.SetActive(false);
        botaoSair.SetActive(false);
    }

}
