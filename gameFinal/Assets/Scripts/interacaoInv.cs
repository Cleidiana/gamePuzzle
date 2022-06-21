using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interacaoInv : MonoBehaviour
{
    public bool interagiu;
    public GameObject Legenda;
    public GameObject textoLegenda;
    public GameObject inventarioBag;

    private void Awake()
    {   
        interagiu = false;
        Legenda.SetActive(false);
        textoLegenda.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(interagiu){
        }
    }
    public void intInvEnable(int aux){
        interagiu = true;
        Legenda.SetActive(true);
        textoLegenda.SetActive(true);
        if (aux == 0)
        {
            textoLegenda.GetComponent<Text>().text = "Relé \n\nRelé 3V.";
        }
        else if (aux == 1)
        {
            textoLegenda.GetComponent<Text>().text = "Sensor de Chuva \n\nQuando há chuva a saída do sensor fica em estado baixo.";
        }
        else if (aux == 2)
        {
            textoLegenda.GetComponent<Text>().text = "ESP32 \n\n";
        }
        else if (aux == 3)
        {
            textoLegenda.GetComponent<Text>().text = "Motor \n\n";
        }
        else if (aux == 4)
        {
            textoLegenda.GetComponent<Text>().text = "Sensor de temperatura e humidade(DHT11) \n\n";
        }
        else if (aux == 5)
        {
            textoLegenda.GetComponent<Text>().text = "Buzzer \n\n";
        }
        else if (aux == 6)
        {
            textoLegenda.GetComponent<Text>().text = "Microfone \n\n";
        }
        else if (aux == 7)
        {
            textoLegenda.GetComponent<Text>().text = "Bateria \n\n";
        }
        else if (aux == 8)
        {
            textoLegenda.GetComponent<Text>().text = "Sensor de corrente \n\n";
        }
        else if (aux == 9)
        {
            textoLegenda.GetComponent<Text>().text = "Sensor de umidade no solo \n\n";
        }
        else if (aux == 10)
        {
            textoLegenda.GetComponent<Text>().text = "Bomba para irrigação \n\n";
        }
        else if (aux == 11)
        {
            textoLegenda.GetComponent<Text>().text = "Relé \n\nRelé 5V.";
        }

    }
    public void intInvDisable(int aux){
        interagiu = false;
        Legenda.SetActive(false);
        textoLegenda.SetActive(false);
    }
}
