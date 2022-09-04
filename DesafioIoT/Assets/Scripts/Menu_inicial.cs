using System.Collections;
using System.Collections.Generic;
using System;
using System.Net;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_inicial : MonoBehaviour {

    public string nomeDaCena;
    public AudioSource SomMenu;
    public Text downloaded;
    
    public void MudaCena() {
        downloaded.gameObject.SetActive(false);
        downloaded.text = "";
        SomMenu.Stop();
        SceneManager.LoadScene(nomeDaCena);
        
    }

    public void Sair()
    {
        Application.Quit();
    }
    private const string UriString = "https://drive.google.com/uc?export=download&id=1QzbzfPLdMUVpOHC8LjZzCL8-Xk1bHC2V";
    private const string fileDownload = "Desafio_IoT.pdf";

    public void Download()
    {
        

    }
    private void DownloadTerminou(object sender, DownloadDataCompletedEventArgs e)
    {
        downloaded.gameObject.SetActive(true);
        downloaded.text = "Download terminado!";
        
        File.WriteAllBytes(fileDownload, e.Result);
    }
}
