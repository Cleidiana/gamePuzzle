using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioUi : MonoBehaviour {

    public Transform bag;
    public GameObject invUi;
    public InventarioSlot[] slots;

	// Use this for initialization
	void Start () {
        Inventario.instance.ItemAlteradoE += UiMetodo;
        slots = bag.GetComponentsInChildren<InventarioSlot>();
    }
    void UiMetodo() {

        for (int i = 0; i < slots.Length; i++) {
            if (i < Inventario.instance.itens.Count)
            {
                slots[i].AdicionaItem(Inventario.instance.itens[i]);
            }
            else {
                slots[i].LimpaSlot();
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
