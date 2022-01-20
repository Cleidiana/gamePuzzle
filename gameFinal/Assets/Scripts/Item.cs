using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Itens", menuName = "Inventario/Item")]

public class Item : MonoBehaviour {

    public string nome;
    public Sprite icone;

    public virtual void Usar() {
        Debug.Log("Usando" + nome);
    }

    public void removeI() {
        Inventario.instance.RemoveItem(this);
    }
}
