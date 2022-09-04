using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventarioSlot : MonoBehaviour {

    
    public Image iconeSlot;
    public Button removeBtn;
    public Item item;

    public static InventarioSlot instance;

    private void Awake()
    {
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
            if (Programacao.instance.getComputador()) {
                if (Missao.instance.getObs() == 1)
                {
                    if (item.name == "esp")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    else if (item.name == "sensorChuva")
                    {
                        Programacao.instance.okHWs(1);
                        Inventario.instance.RemoveItem(item);
                    }
                    Programacao.instance.okHWs(2);
           
                }
                else if (Missao.instance.getObs() == 2)
                {
                    if (item.name == "motor")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    Programacao.instance.okHWs(1);   
                    Programacao.instance.okHWs(2);

                }
                else if (Missao.instance.getObs() == 3)
                {
                    if (item.name == "sensorUmidade")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    else if (item.name == "esp")
                    {
                        Programacao.instance.okHWs(1);
                        Inventario.instance.RemoveItem(item);
                    }
                    Programacao.instance.okHWs(2);

                }
                else if (Missao.instance.getObs() == 4)
                {
                    if (item.name == "bombaIrrigacao")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    Programacao.instance.okHWs(1);
                    Programacao.instance.okHWs(2);

                }
                else if (Missao.instance.getObs() == 5)
                {
                    Programacao.instance.okHWs(0);
                    Programacao.instance.okHWs(1);
                    Programacao.instance.okHWs(2);

                }
                else if (Missao.instance.getObs() == 6)
                {
                    if (item.name == "esp")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    else if (item.name == "sensorCorrente")
                    {
                        Programacao.instance.okHWs(1);
                        Inventario.instance.RemoveItem(item);
                    }
                    Programacao.instance.okHWs(2);

                }
                else if (Missao.instance.getObs() == 7)
                {
                    if (item.name == "sensorTemperatura")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    Programacao.instance.okHWs(1);
                    Programacao.instance.okHWs(2);

                }
                else if (Missao.instance.getObs() == 8)
                {
                    if (item.name == "rele3v")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    Programacao.instance.okHWs(1);
                    Programacao.instance.okHWs(2);

                }
                else if (Missao.instance.getObs() == 9)
                {
                    if (item.name == "esp")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    else if (item.name == "rtc")
                    {
                        Programacao.instance.okHWs(1);
                        Inventario.instance.RemoveItem(item);
                    }
                    else if (item.name == "rele3v")
                    {
                        Programacao.instance.okHWs(2);
                        Inventario.instance.RemoveItem(item);
                    }

                }
                else if (Missao.instance.getObs() == 10)
                {
                    if (item.name == "rele3v")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    Programacao.instance.okHWs(1);
                    Programacao.instance.okHWs(2);

                }
                else if (Missao.instance.getObs() == 11)
                {
                    if (item.name == "buzzer")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    Programacao.instance.okHWs(1);
                    Programacao.instance.okHWs(2);

                }
                else if (Missao.instance.getObs() == 12)
                {
                    if (item.name == "bateria")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    Programacao.instance.okHWs(1);
                    Programacao.instance.okHWs(2);

                }
                else if (Missao.instance.getObs() == 13)
                {
                    if (item.name == "esp")
                    {
                        Programacao.instance.okHWs(0);
                        Inventario.instance.RemoveItem(item);
                    }
                    else if (item.name == "microfone")
                    {
                        Programacao.instance.okHWs(1);
                        Inventario.instance.RemoveItem(item);
                    }
                    else if (item.name == "rele3v")
                    {
                        Programacao.instance.okHWs(2);
                        Inventario.instance.RemoveItem(item);
                    }

                }
            }
            
        }
    }

    public void DisableHW()
    {

        for (int i = 0; i < 3; i++)
        {
            Inventario.instance.RemoveItem(item);
        }
    }

    private void Start()
    {
        removeBtn = transform.GetChild(0).GetComponent<Button>();
        iconeSlot = transform.GetChild(1).GetComponent<Image>();
    }
}
