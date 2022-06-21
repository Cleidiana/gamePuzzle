using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Missao : MonoBehaviour {

    public static Missao instance;
    List<string> Mis = new List<string>();
    public AudioSource SomGeral;
    public GameObject MissaoSom;
    public GameObject AmbSom;
    public GameObject pauseSom;
    public int objetivo = 0;
    public int lastObjetivo = -1;
    public Text missoes;
    public Image img;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        SomGeral = AmbSom.GetComponent<AudioSource>();
        SomGeral.Play();
        img.gameObject.SetActive(false);
    }
    // Use this for initialization
    void Start () {
        objetivo = 0;
        Mis.Add("Projeto 1 - V0\nMonitore a presença de chuva na casa, por wifi.");
        Mis.Add("Projeto 1 - V1\nCom ajuda de um motor feche as janelas quando chover.");

    }

    private static void onTime()
    {
        TimeUI.instance.stTimeUI(true);
    }
    // Update is called once per frame
    void Update () {
        
        if (lastObjetivo == 0 && objetivo != 0)
        {
            onTime();
            img.gameObject.SetActive(true);
            missoes.text = Mis[objetivo - 1];

        }
       
    }

    public void setObs(int id) {
        if (id == 0) {
            SomGeral.Stop();
            SomGeral = AmbSom.GetComponent<AudioSource>();
            SomGeral.Play();
            missoes.text = "";
            img.gameObject.SetActive(false);
            TimeUI.instance.stTimeUI(false);
        }
        if (id != objetivo) {
            lastObjetivo = objetivo;
            objetivo = id;
        }
        if (lastObjetivo == 0 && objetivo != 0)
        {
            SomGeral.Stop();
            SomGeral = MissaoSom.GetComponent<AudioSource>();
            SomGeral.Play();

        }
    }
    public int getObs()
    {
        return objetivo;
    }
    public void playPensar(bool test) {
        SomGeral.Stop();
        if (test)
        {
            SomGeral = pauseSom.GetComponent<AudioSource>();
        }
        else {
            if (Missao.instance.getObs() == 0)
            {
                SomGeral = AmbSom.GetComponent<AudioSource>();
            }
            else {
                SomGeral = MissaoSom.GetComponent<AudioSource>();
            }
            
        }
        SomGeral.Play();
    }


}
