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
        Mis.Add("Pegue o HW correto");
        Mis.Add("Programe");

    }
	
	// Update is called once per frame
	void Update () {
        if (objetivo == 1) {
            TimeUI.instance.startTimeUI();
            missoes.text = Mis[0];
        }
        if (objetivo == 2)
        {
            missoes.text = Mis[1];
        }
    }
    public void setObs(int id) {
        objetivo = id;
    }
}
