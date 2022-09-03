using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour {

    public static Inventario instance;

    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }

    public delegate void ItemAlterado();
    public event ItemAlterado ItemAlteradoE;
    [SerializeField]
    private int countSlots;
    public List<Item> itens = new List<Item>();

    public bool adicionaItem(Item i) {
        if (itens.Count >= countSlots) {
            return false;
        }
        itens.Add(i);

        if (ItemAlteradoE != null) {
            ItemAlteradoE();
        }
        return true;

    }
    public void RemoveItem(Item i) {
        itens.Remove(i);
        if (ItemAlteradoE != null)
        {
            ItemAlteradoE();
        }

    }
}
