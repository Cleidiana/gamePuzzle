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
        if(aux == 0){
            textoLegenda.GetComponent<Text>().text = "Arduinooo"; 
        }
        
    }
    public void intInvDisable(int aux){
        interagiu = false;
        Legenda.SetActive(false);
        textoLegenda.SetActive(false);
    }
}
