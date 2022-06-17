using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioSlot : MonoBehaviour {

    
    public Image iconeSlot;
    public Button removeBtn;
    public Item item;
    private bool atual1 = false, atual2 = false, atual3 = false;
    private bool testComp = false;
    // Use this for initialization

    public static InventarioSlot instance;

    private void Awake()
    {
        atual1 = false;
        atual2 = false;
        atual3 = false;
        if (instance == null)
        {
            instance = this;
        }
    }
    public void AdicionaItem(Item i) {
        item = i;
        iconeSlot.sprite = item.icone;
        iconeSlot.enabled = true;
        iconeSlot.preserveAspect = true;
        removeBtn.interactable = true;
    }

    public void LimpaSlot() {
        item = null;
        iconeSlot.sprite = null;
        iconeSlot.enabled = false;
        removeBtn.interactable = false;
    }

    public void LimpaStateAtual()
    {
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
            if (testComp) {
                Debug.Log("Usando " + item.name);

                if (Missao.instance.getObs() == 1)
                {
                    if (item.name == "esp")
                    {
                        atual1 = true;
                        Inventario.instance.RemoveItem(item);
                    }
                    else if (item.name == "sensorChuva")
                    {
                        atual2 = true;
                        Inventario.instance.RemoveItem(item);
                    }
                    atual3 = true;

                    Debug.Log("T1 " + atual1);
                    Debug.Log("T2 " + atual2);
                    bool ret = atual1 & atual2 & atual3;
                    if (ret) {
                        Debug.Log("HW OK");
                        Programacao.instance.setOkHW(ret);
                        Programacao.instance.ligarComputador();
                    }
                        
                }
            }
            
        }
    }

    public void TestHW()
    {
        bool ret = atual1 & atual2 & atual3;
        Programacao.instance.setOkHW(ret);
    }

    public void SetHW()
    {
        atual1 = false;
        atual2 = false;
        atual3 = false;
    }
    public void computadorOn(bool val)
    {
        testComp = val;
    }

    private void Start()
    {
        removeBtn = transform.GetChild(0).GetComponent<Button>();
        iconeSlot = transform.GetChild(1).GetComponent<Image>();
    }
}
