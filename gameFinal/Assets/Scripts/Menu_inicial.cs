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
    private const string UriString = "https://drive.google.com/uc?export=download&id=1hoY8S4woiHc46_1U8bUAHxZ2D0-wM6oy";
    private const string fileDownload = "Manual.txt";

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
