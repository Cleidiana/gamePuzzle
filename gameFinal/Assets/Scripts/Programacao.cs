using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Programacao : MonoBehaviour {

    public GameObject textoInput;
    public GameObject textoOut;
    public GameObject computador;
    public GameObject build;
    public GameObject ota;
    private CircleCollider2D abrirComputador;
    private string code;

    public void Awake()
    {
        computador.SetActive(false);
        textoOut.SetActive(false);
        textoInput.SetActive(false);
        build.SetActive(false);
        ota.SetActive(false);
        abrirComputador = GetComponent<CircleCollider2D>();
    }
    public void buildCode() {
        code = textoInput.GetComponent<Text>().text;
        if(code == "if test"){
            textoOut.GetComponent<Text>().text = "ok deu certo"; 
        }
        else {
            textoOut.GetComponent<Text>().text = code; 
        }
    }
    public void otaCode() {
        code = textoInput.GetComponent<Text>().text;
        textoOut.GetComponent<Text>().text = code; 
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        computador.SetActive(true);
        textoOut.SetActive(true);
        textoInput.SetActive(true);
        build.SetActive(true);
        ota.SetActive(true);
        Movimento_personagem.instance.SetVelocidade(0);
    }

}
