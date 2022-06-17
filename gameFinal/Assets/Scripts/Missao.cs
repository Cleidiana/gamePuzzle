using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Missao : MonoBehaviour {

    public static Missao instance;
    List<string> Mis = new List<string>();
    private int objetivo;
    public Text missoes;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Use this for initialization
    void Start () {
        objetivo = 0;
        Mis.Add("Projeto 1 - V0\nMonitore a presença de chuva na casa, por wifi.");
        Mis.Add("Projeto 1 - V1\nCom ajuda de um motor feche as janelas quando chover.");

    }
	
	// Update is called once per frame
	void Update () {
        if (objetivo != 0)
        {
            onTime();
        }
        if (objetivo == 1) {

            missoes.text = Mis[0];
        }
        if (objetivo == 2)
        {
            missoes.text = Mis[1];
        }
    }

    private static void onTime()
    {
        TimeUI.instance.stTimeUI(true);
    }

    public void setObs(int id) {
        objetivo = id;
    }
    public int getObs()
    {
        return objetivo;
    }

    public int setOkHW(int id)
    {
        return objetivo;
    }

    public int getIfOkHW(int id)
    {
        return objetivo;
    }
}
