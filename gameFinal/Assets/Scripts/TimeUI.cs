using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour {
    [SerializeField]
    public Text displayCont;
    public float contagem = 30.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (contagem > 0.0f)
        {
            contagem -= Time.deltaTime;
            displayCont.text = contagem.ToString("0");
        }
        else {
            displayCont.text = "0";
                
        }
	}
}
