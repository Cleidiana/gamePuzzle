using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour {
    [SerializeField]
    public Text displayCont;
    public GameObject fundoTime;
    public float contagem = 30.0f;
    private bool startTime = false;
    public static TimeUI instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start () {
        displayCont.text = "";
        fundoTime.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (startTime)
        {
            fundoTime.SetActive(true);
            if (contagem > 0.0f)
            {
                contagem -= Time.deltaTime;
                displayCont.text = contagem.ToString("0");
            }
            else
            {
                displayCont.text = "0";
                startTime = false;
                //displayCont.text = "";
                //fundoTime.SetActive(false);

            }

        }
        
	}
    public void startTimeUI()
    {
        startTime = true;
    }
}
