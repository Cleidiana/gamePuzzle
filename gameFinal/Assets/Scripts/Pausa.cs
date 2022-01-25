using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.IO;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour {
    public GameObject MenuPausado;

    // Use this for initialization
    void Awake() {
        MenuPausado.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Escape)) {
            MenuPausado.SetActive(true);
        }
    }

    private const string UriString = "https://drive.google.com/uc?export=download&id=1hoY8S4woiHc46_1U8bUAHxZ2D0-wM6oy";
    private const string fileDownload = "Manual.txt";

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
        MenuPausado.SetActive(false);
    }

}
