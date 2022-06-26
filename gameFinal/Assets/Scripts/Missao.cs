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
    public GameObject vitoriaSom;
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
        Mis.Add("Projeto 1 - V1\nFeche as janelas quando chover.");
        Mis.Add("Projeto 2 - V0\nMonitore a umidade do solo das flores, por bluetooth.");
        Mis.Add("Projeto 2 - V1\nCom ajuda da bomba de irrigação, regue as plantas quando necessário.");
        Mis.Add("Projeto 2 - V2\nAs plantas estão secas, altere a rega para quando a umidade do solo estiver abaixo de 70%");
        Mis.Add("Projeto 3 - V0\nMonitore a corrente elétrica do ar condicionado, por bluetooth.");
        Mis.Add("Projeto 3 - V1\nMonitore a temperatura e umidade da casa, por bluetooth.");
        Mis.Add("Projeto 3 - V2\nDesligue o ar condicionado quando estiver ligado sem necessidade.");
        Mis.Add("Projeto 4 - V0\nLigue o alimentador do cachorro às 8h e às 17h. Avise por wifi.");
        Mis.Add("Projeto 4 - V1\nPrepare um café às 7h, ligando a cafeteira.");
        Mis.Add("Projeto 4 - V2\nAgende um alerta sonoro, por 5min, às 7h30. Avise por wifi.");
        Mis.Add("Projeto 4 - V3\nAltere a alimentação do projeto para bateria e mude a conectividade para bluetooth.");
        Mis.Add("Projeto 5 - V0\nUsando controle de voz, ligue e desligue as lâmpadas. Avise por wifi.");

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

    public void playFinal()
    {
        SomGeral.Stop();
        SomGeral = vitoriaSom.GetComponent<AudioSource>();
        SomGeral.Play();
        img.gameObject.SetActive(true);
        missoes.text = "Parabéns!! Você concluiu todas as missões!!";

    }
}
