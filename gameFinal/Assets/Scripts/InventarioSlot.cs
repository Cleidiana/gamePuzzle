using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioSlot : MonoBehaviour {
    public Image iconeSlot;
    public Button removeBtn;
    public Item item;

    public void AdicionaItem(Item i) {
        item = i;
        iconeSlot.sprite = item.icone;
        iconeSlot.enabled = true;
        removeBtn.interactable = true;
    }

    public void LimpaSlot() {
        item = null;
        iconeSlot.sprite = null;
        iconeSlot.enabled = false;
        removeBtn.interactable = false;
    }
    public void ChamaRemoveBtn() {
        Inventario.instance.RemoveItem(item);
    }
    public void UsaItem()
    {
        if (item != null) {
            item.Usar();
        }
    }

    private void Start()
    {
        removeBtn = transform.GetChild(0).GetComponent<Button>();
        iconeSlot = transform.GetChild(1).GetComponent<Image>();
    }
}
