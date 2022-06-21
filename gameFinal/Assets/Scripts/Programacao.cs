using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Programacao : MonoBehaviour {

    public static Programacao instance;
    public GameObject textoDefautProg1;
    public GameObject textoDefautProg2;
    public GameObject imgInp1, imgInp2, imgInp3, imgInp4, imgInp5, imgInp6, imgInp7, imgInp8, imgInp9, imgInp10;
    public GameObject txtInp1, txtInp2, txtInp3, txtInp4, txtInp5, txtInp6, txtInp7, txtInp8, txtInp9, txtInp10;
    public GameObject textoOut;   
    public GameObject computador;
    public GameObject build;
    public GameObject saiHW;
    public GameObject ota;
    public GameObject fecha;
    public GameObject txtHW;
    public GameObject tileN1, N1, tileN1_1, N1_1;
    private CircleCollider2D abrirComputador;
    private string code;
    private bool okHW = false, InvTestComp = false;
    private bool atual1 = false, atual2 = false, atual3 = false;

    private void desativaInput() {

        txtInp1.SetActive(false);
        txtInp2.SetActive(false);
        txtInp3.SetActive(false);
        txtInp4.SetActive(false);
        txtInp5.SetActive(false);
        txtInp6.SetActive(false);
        txtInp7.SetActive(false);
        txtInp8.SetActive(false);
        txtInp9.SetActive(false);
        imgInp1.SetActive(false);
        imgInp2.SetActive(false);
        imgInp3.SetActive(false);
        imgInp4.SetActive(false);
        imgInp5.SetActive(false);
        imgInp6.SetActive(false);
        imgInp7.SetActive(false);
        imgInp8.SetActive(false);
        imgInp9.SetActive(false);
    }
    public void Awake()
    {
        atual1 = false;
        atual2 = false;
        atual3 = false;
        txtHW.SetActive(false);
        computador.SetActive(false);
        textoOut.SetActive(false);
        desativaInput();
        build.SetActive(false);
        saiHW.SetActive(false);
        ota.SetActive(false);
        fecha.SetActive(false);
        textoDefautProg1.SetActive(false);
        textoDefautProg2.SetActive(false);
        abrirComputador = GetComponent<CircleCollider2D>();
        tileN1_1.SetActive(false);
        N1_1.SetActive(false);


        if (instance == null)
        {
            instance = this;
        }
        
    }
    public void buildCode() {
        code = txtInp1.GetComponent<Text>().text;
        if (Missao.instance.getObs() == 1)
        {

            if (code == "wifi_start();")
            {
                code = txtInp2.GetComponent<Text>().text;
                if (code == "mqtt_app_start();")
                {
                    code = txtInp3.GetComponent<Text>().text;
                    if (code == "sensor_chuva_init();")
                    {
                        code = txtInp4.GetComponent<Text>().text;
                        if (code == "mqtt_pub_val(sensorChuva_meas());")
                        {
                            code = txtInp5.GetComponent<Text>().text;
                            if (code == "vTaskDelay(pdMS_TO_TICKS(1000)*60*10);")
                            {
                                textoOut.GetComponent<Text>().text = "OK, procure a proxima missão";
                                Missao.instance.setObs(0);
                                atual1 = false;
                                atual2 = false;
                                atual3 = false;
                                InventarioSlot.instance.DisableHW();
                                tileN1.SetActive(false);
                                N1.SetActive(false);
                                tileN1_1.SetActive(true);
                                N1_1.SetActive(true);
                                Missao.instance.playPensar(false);
                                setOkHW(false);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "erro input 5";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "erro input 4";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "erro input 3";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "erro input 2";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "erro input 1";
            }
        }

    }
    public void otaCode() {
        code = txtInp6.GetComponent<Text>().text;
        if (Missao.instance.getObs() == 2)
        {
            if (code == "motor_start();")
            {
                code = txtInp7.GetComponent<Text>().text;
                if (code == "get_sensor_chuva() == true")
                {
                    code = txtInp8.GetComponent<Text>().text;
                    if (code == "motor_on();")
                    {
                        code = txtInp9.GetComponent<Text>().text;
                        if (code == "motor_off();")
                        {
                            textoOut.GetComponent<Text>().text = "OK, procure a proxima missão";
                            Missao.instance.setObs(0);
                            atual1 = false;
                            atual2 = false;
                            atual3 = false;
                            InventarioSlot.instance.DisableHW();
                            tileN1_1.SetActive(false);
                            N1_1.SetActive(false);
                            Missao.instance.playPensar(false);
                            setOkHW(false);
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "erro input 4";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "erro input 3";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "erro input 2";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "erro input 1";
            }
        }

    }

    public void saiTestHW()
    {
        txtHW.SetActive(false);
        saiHW.SetActive(false);
        TimeUI.instance.onPause(false);
        txtHW.transform.GetChild(1).GetComponent<Text>().text = "";
        Missao.instance.playPensar(false);
        Movimento_personagem.instance.SetVelocidade(5f);

    }

    public void fechaCode()
    {
        txtHW.transform.GetChild(1).GetComponent<Text>().text = "";
        atual1 = false;
        atual2 = false;
        atual3 = false;
        Missao.instance.playPensar(false);
        InventarioSlot.instance.DisableHW();
        txtHW.SetActive(false);
        saiHW.SetActive(false);
        txtHW.SetActive(false);
        computador.SetActive(false);
        textoOut.SetActive(false);
        desativaInput();
        build.SetActive(false);
        ota.SetActive(false);
        textoDefautProg1.SetActive(false);
        textoDefautProg2.SetActive(false);
        fecha.SetActive(false);
        InvTestComp = false;
        TimeUI.instance.onPause(false);
        Movimento_personagem.instance.SetVelocidade(5f);

    }

    public void ligarComputador()
    {
        if (Missao.instance.getObs() != 0) {
            
            computador.SetActive(true);
            if (Missao.instance.getObs() == 1)
            {
                txtInp1.SetActive(true);
                txtInp2.SetActive(true);
                txtInp3.SetActive(true);
                txtInp4.SetActive(true);
                txtInp5.SetActive(true);
                imgInp1.SetActive(true);
                imgInp2.SetActive(true);
                imgInp3.SetActive(true);
                imgInp4.SetActive(true);
                imgInp5.SetActive(true);
                textoDefautProg1.SetActive(true);
            }
            if (Missao.instance.getObs() == 2)
            {
                txtInp6.SetActive(true);
                txtInp7.SetActive(true);
                txtInp8.SetActive(true);
                txtInp9.SetActive(true);
                imgInp6.SetActive(true);
                imgInp7.SetActive(true);
                imgInp8.SetActive(true);
                imgInp9.SetActive(true);
                textoDefautProg2.SetActive(true);
            }
            computador.SetActive(true);
            textoOut.SetActive(true);
            build.SetActive(true);
            ota.SetActive(true);
            fecha.SetActive(true);
            textoOut.GetComponent<Text>().text = "";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Missao.instance.getObs() != 0) {
            Missao.instance.playPensar(true);
            TimeUI.instance.onPause(true);
            Movimento_personagem.instance.SetVelocidade(0);

            InvTestComp = true;
            if (okHW)
            {
                txtHW.transform.GetChild(1).GetComponent<Text>().text = "";
                txtHW.SetActive(false);
                saiHW.SetActive(false);
                ligarComputador();
            }
            else
            {
                txtHW.SetActive(true);
                saiHW.SetActive(true);
                txtHW.transform.GetChild(1).GetComponent<Text>().text = "Escolha os itens de HW";
            }
        }
       
    }

    public bool getOkHW()
    {
        return okHW;
    }
    public void setOkHW(bool val)
    {
        okHW = val;
    }

    public void okHWs(int id)
    {
        if (id == 0)
        {
            atual1 = true;
        }
        else if (id == 1)
        {
            atual2 = true;
        }
        else
        {
            atual3 = true;
        }
        if (atual1 && atual2 && atual3)
        {
            setOkHW(true);
            ligarComputador();
        }
    }

    public bool getComputador()
    {
        return InvTestComp;
    }


}
