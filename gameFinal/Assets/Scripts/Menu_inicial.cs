using System.Collections;
using System.Collections.Generic;
using System;
using System.Net;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_inicial : MonoBehaviour {

    public string nomeDaCena;
    public AudioSource SomMenu;

    public void MudaCena() {
        SceneManager.LoadScene(nomeDaCena);
        SomMenu.Stop();
    }

    public void Sair()
    {
        Application.Quit();
    }
    private const string UriString = "https://drive.google.com/uc?export=download&id=1QzbzfPLdMUVpOHC8LjZzCL8-Xk1bHC2V";
    private const string fileDownload = "Desafio_IoT.pdf";

    public void Download()
    {
        WebClient webClient = new WebClient();
        webClient.DownloadDataAsync(new Uri(UriString));
        webClient.DownloadDataCompleted += DownloadTerminou;


    }
    private void DownloadTerminou(object sender, DownloadDataCompletedEventArgs e)
    {
        File.WriteAllBytes(fileDownload, e.Result);
    }
}
