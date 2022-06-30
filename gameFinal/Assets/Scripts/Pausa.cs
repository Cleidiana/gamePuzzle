using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.IO;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour {
    public GameObject MenuPausado;

    void Awake() {

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
        WebClient webClient = new WebClient();
        webClient.DownloadDataAsync(new Uri(UriString));
        webClient.DownloadDataCompleted += DownloadTerminou;

    }
    private void DownloadTerminou(object sender, DownloadDataCompletedEventArgs e)
    {
        File.WriteAllBytes(fileDownload, e.Result);
    }

    public void sairJogo() {
        Application.Quit();
    }
    public void voltarJogo()
    {
        TimeUI.instance.onPause(false);
        MenuPausado.SetActive(false);
        Missao.instance.playPensar(false);
    }
    
}
