using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Missao : MonoBehaviour {

    public static Missao instance;
    List<string> Mis = new List<string>();
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
            missoes.text = "";
            img.gameObject.SetActive(false);
            TimeUI.instance.stTimeUI(false);
        }
        if (id != objetivo) {
            lastObjetivo = objetivo;
            objetivo = id;
        }
    }
    public int getObs()
    {
        return objetivo;
    }

}
