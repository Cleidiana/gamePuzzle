using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.IO;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pausa : MonoBehaviour {
    public GameObject MenuPausado;
    public Text downloaded;
    public Image downloadedImg;
    void Awake() {
        downloaded.gameObject.SetActive(false);
        downloadedImg.gameObject.SetActive(false);
        downloaded.text = "";
        MenuPausado.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Escape)) {
            TimeUI.instance.onPause(true);
            MenuPausado.SetActive(true);
            Missao.instance.playPensar(true);


        }
    }

    private const string UriString = "https://drive.google.com/uc?export=download&id=1QzbzfPLdMUVpOHC8LjZzCL8-Xk1bHC2V";
    private const string fileDownload = "Desafio_IoT.pdf";

    public void PegarManual()
    {
        
    }
    private void DownloadTerminou(object sender, DownloadDataCompletedEventArgs e)
    {
        downloaded.gameObject.SetActive(true);
        downloadedImg.gameObject.SetActive(true);
        downloaded.text = "Download terminado!";
        File.WriteAllBytes(fileDownload, e.Result);
    }

    public void sairJogo() {
        Application.Quit();
    }
    public void voltarJogo()
    {
        downloaded.gameObject.SetActive(false);
        downloadedImg.gameObject.SetActive(false);
        downloaded.text = "";
        TimeUI.instance.onPause(false);
        MenuPausado.SetActive(false);
        Missao.instance.playPensar(false);
    }
    
}
