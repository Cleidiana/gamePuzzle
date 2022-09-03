using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacao : MonoBehaviour {

    public Item item;
    public bool foiPego;

    public void Coleta()
    {
        Debug.Log("Pegando" + item.nome);
        foiPego = Inventario.instance.adicionaItem(item);

    }
}
