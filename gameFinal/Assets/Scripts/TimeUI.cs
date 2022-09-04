using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour {
    [SerializeField]
    public Text displayCont;
    public GameObject fundoTime;
    List<float> TimeMis = new List<float>();
    public float contagem = 0f;
    private bool startTime = false, lastTime = false;
    public static TimeUI instance;
    public bool isPausado = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        TimeMis.Add(60.0f);
        TimeMis.Add(45.0f);
        TimeMis.Add(60.0f);
        TimeMis.Add(60.0f);
        TimeMis.Add(10.0f);
        TimeMis.Add(45.0f);
        TimeMis.Add(45.0f);
        TimeMis.Add(45.0f);
        TimeMis.Add(60.0f);
        TimeMis.Add(60.0f);
        TimeMis.Add(60.0f);
        TimeMis.Add(90.0f);
        TimeMis.Add(90.0f);
        displayCont.text = "";
        fundoTime.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (startTime)
        {
            fundoTime.SetActive(true);
            if (!isPausado)
            {
                if (contagem > 0.0f)
                {
                    contagem -= Time.deltaTime;
                    displayCont.text = contagem.ToString("0");
                }
                else
                {
                    displayCont.text = "0";
                    startTime = false;
                    Missao.instance.setObs(0);
                    InventarioSlot.instance.DisableHW();
                    Programacao.instance.limpaHWs();
                    //displayCont.text = "";
                    //fundoTime.SetActive(false);

                }

            }
        }
        else {
            displayCont.text = "";
            fundoTime.SetActive(false);
        }
        
	}
    public void stTimeUI(bool val)
    {
        if (Missao.instance.getObs() != 0) {

            if (!lastTime)
            {
                contagem = TimeMis[Missao.instance.getObs() - 1];
                lastTime = true;
            }
            if (!val)
            {
                lastTime = false;
                
                displayCont.text = "";
                fundoTime.SetActive(false);
            }
            startTime = val;
        }
    }

    public void onPause(bool state)
    {
        isPausado = state;

    }
}
