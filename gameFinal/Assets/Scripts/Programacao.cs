using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Programacao : MonoBehaviour {

    public static Programacao instance;
    public GameObject textoDefautProg1, textoDefautProg2, textoDefautProg3, textoDefautProg4, textoDefautProg5, textoDefautProg6, textoDefautProg7, textoDefautProg8, textoDefautProg9, textoDefautProg10, textoDefautProg11, textoDefautProg12, textoDefautProg13;

    public GameObject Prog1_imgInp1, Prog1_imgInp2, Prog1_imgInp3, Prog1_imgInp4, Prog1_imgInp5;
    public GameObject Prog2_imgInp1, Prog2_imgInp2, Prog2_imgInp3, Prog2_imgInp4, Prog2_imgInp5;
    public GameObject Prog3_imgInp1, Prog3_imgInp2, Prog3_imgInp3, Prog3_imgInp4, Prog3_imgInp5;
    public GameObject Prog4_imgInp1, Prog4_imgInp2, Prog4_imgInp3, Prog4_imgInp4, Prog4_imgInp5;
    public GameObject Prog5_imgInp1, Prog5_imgInp2, Prog5_imgInp3, Prog5_imgInp4, Prog5_imgInp5;
    public GameObject Prog6_imgInp1, Prog6_imgInp2, Prog6_imgInp3, Prog6_imgInp4, Prog6_imgInp5;
    public GameObject Prog7_imgInp1, Prog7_imgInp2, Prog7_imgInp3, Prog7_imgInp4, Prog7_imgInp5;
    public GameObject Prog8_imgInp1, Prog8_imgInp2, Prog8_imgInp3, Prog8_imgInp4, Prog8_imgInp5;
    public GameObject Prog9_imgInp1, Prog9_imgInp2, Prog9_imgInp3, Prog9_imgInp4, Prog9_imgInp5;
    public GameObject Prog10_imgInp1, Prog10_imgInp2, Prog10_imgInp3, Prog10_imgInp4, Prog10_imgInp5;
    public GameObject Prog11_imgInp1, Prog11_imgInp2, Prog11_imgInp3, Prog11_imgInp4, Prog11_imgInp5;
    public GameObject Prog12_imgInp1, Prog12_imgInp2, Prog12_imgInp3, Prog12_imgInp4, Prog12_imgInp5;
    public GameObject Prog13_imgInp1, Prog13_imgInp2, Prog13_imgInp3, Prog13_imgInp4, Prog13_imgInp5;
    public GameObject Prog1_txtInp1, Prog1_txtInp2, Prog1_txtInp3, Prog1_txtInp4, Prog1_txtInp5;
    public GameObject Prog2_txtInp1, Prog2_txtInp2, Prog2_txtInp3, Prog2_txtInp4, Prog2_txtInp5;
    public GameObject Prog3_txtInp1, Prog3_txtInp2, Prog3_txtInp3, Prog3_txtInp4, Prog3_txtInp5;
    public GameObject Prog4_txtInp1, Prog4_txtInp2, Prog4_txtInp3, Prog4_txtInp4, Prog4_txtInp5;
    public GameObject Prog5_txtInp1, Prog5_txtInp2, Prog5_txtInp3, Prog5_txtInp4, Prog5_txtInp5;
    public GameObject Prog6_txtInp1, Prog6_txtInp2, Prog6_txtInp3, Prog6_txtInp4, Prog6_txtInp5;
    public GameObject Prog7_txtInp1, Prog7_txtInp2, Prog7_txtInp3, Prog7_txtInp4, Prog7_txtInp5;
    public GameObject Prog8_txtInp1, Prog8_txtInp2, Prog8_txtInp3, Prog8_txtInp4, Prog8_txtInp5;
    public GameObject Prog9_txtInp1, Prog9_txtInp2, Prog9_txtInp3, Prog9_txtInp4, Prog9_txtInp5;
    public GameObject Prog10_txtInp1, Prog10_txtInp2, Prog10_txtInp3, Prog10_txtInp4, Prog10_txtInp5;
    public GameObject Prog11_txtInp1, Prog11_txtInp2, Prog11_txtInp3, Prog11_txtInp4, Prog11_txtInp5;
    public GameObject Prog12_txtInp1, Prog12_txtInp2, Prog12_txtInp3, Prog12_txtInp4, Prog12_txtInp5;
    public GameObject Prog13_txtInp1, Prog13_txtInp2, Prog13_txtInp3, Prog13_txtInp4, Prog13_txtInp5;

    public GameObject textoOut;   
    public GameObject computador;
    public GameObject build;
    public GameObject saiHW;
    public GameObject ota;
    public GameObject fecha;
    public GameObject txtHW;
    public GameObject tileN1_0, N1_0, tileN1_1, N1_1, tileN2_0, N2_0, tileN2_1, N2_1, tileN2_2, N2_2, tileN3_0, N3_0, tileN3_1, N3_1, tileN3_2, N3_2, tileN4_0, N4_0, tileN4_1, N4_1, tileN4_2, N4_2, tileN4_3, N4_3, tileN5, N5;
    private CircleCollider2D abrirComputador;
    private string code;
    private bool okHW = false, InvTestComp = false;
    private bool atual1 = false, atual2 = false, atual3 = false;
    public int countFinal = 0;

    private void desativaInput() {

        Prog1_txtInp1.SetActive(false);
        Prog1_txtInp2.SetActive(false);
        Prog1_txtInp3.SetActive(false);
        Prog1_txtInp4.SetActive(false);
        Prog1_txtInp5.SetActive(false);
        Prog1_imgInp1.SetActive(false);
        Prog1_imgInp2.SetActive(false);
        Prog1_imgInp3.SetActive(false);
        Prog1_imgInp4.SetActive(false);
        Prog1_imgInp5.SetActive(false);

        Prog2_txtInp1.SetActive(false);
        Prog2_txtInp2.SetActive(false);
        Prog2_txtInp3.SetActive(false);
        Prog2_txtInp4.SetActive(false);
        Prog2_txtInp5.SetActive(false);
        Prog2_imgInp1.SetActive(false);
        Prog2_imgInp2.SetActive(false);
        Prog2_imgInp3.SetActive(false);
        Prog2_imgInp4.SetActive(false);
        Prog2_imgInp5.SetActive(false);

        Prog3_txtInp1.SetActive(false);
        Prog3_txtInp2.SetActive(false);
        Prog3_txtInp3.SetActive(false);
        Prog3_txtInp4.SetActive(false);
        Prog3_txtInp5.SetActive(false);
        Prog3_imgInp1.SetActive(false);
        Prog3_imgInp2.SetActive(false);
        Prog3_imgInp3.SetActive(false);
        Prog3_imgInp4.SetActive(false);
        Prog3_imgInp5.SetActive(false);

        Prog4_txtInp1.SetActive(false);
        Prog4_txtInp2.SetActive(false);
        Prog4_txtInp3.SetActive(false);
        Prog4_txtInp4.SetActive(false);
        Prog4_txtInp5.SetActive(false);
        Prog4_imgInp1.SetActive(false);
        Prog4_imgInp2.SetActive(false);
        Prog4_imgInp3.SetActive(false);
        Prog4_imgInp4.SetActive(false);
        Prog4_imgInp5.SetActive(false);

        Prog5_txtInp3.SetActive(false);
        Prog5_txtInp4.SetActive(false);
        Prog5_txtInp5.SetActive(false);
        Prog5_imgInp1.SetActive(false);
        Prog5_imgInp2.SetActive(false);
        Prog5_imgInp3.SetActive(false);
        Prog5_imgInp4.SetActive(false);
        Prog5_imgInp5.SetActive(false);

        Prog6_txtInp1.SetActive(false);
        Prog6_txtInp2.SetActive(false);
        Prog6_txtInp3.SetActive(false);
        Prog6_txtInp4.SetActive(false);
        Prog6_txtInp5.SetActive(false);
        Prog6_imgInp1.SetActive(false);
        Prog6_imgInp2.SetActive(false);
        Prog6_imgInp3.SetActive(false);
        Prog6_imgInp4.SetActive(false);
        Prog6_imgInp5.SetActive(false);

        Prog7_txtInp1.SetActive(false);
        Prog7_txtInp2.SetActive(false);
        Prog7_txtInp3.SetActive(false);
        Prog7_txtInp4.SetActive(false);
        Prog7_txtInp5.SetActive(false);
        Prog7_imgInp1.SetActive(false);
        Prog7_imgInp2.SetActive(false);
        Prog7_imgInp3.SetActive(false);
        Prog7_imgInp4.SetActive(false);
        Prog7_imgInp5.SetActive(false);

        Prog8_txtInp1.SetActive(false);
        Prog8_txtInp2.SetActive(false);
        Prog8_txtInp3.SetActive(false);
        Prog8_txtInp4.SetActive(false);
        Prog8_txtInp5.SetActive(false);
        Prog8_imgInp1.SetActive(false);
        Prog8_imgInp2.SetActive(false);
        Prog8_imgInp3.SetActive(false);
        Prog8_imgInp4.SetActive(false);
        Prog8_imgInp5.SetActive(false);

        Prog9_txtInp1.SetActive(false);
        Prog9_txtInp2.SetActive(false);
        Prog9_txtInp3.SetActive(false);
        Prog9_txtInp4.SetActive(false);
        Prog9_txtInp5.SetActive(false);
        Prog9_imgInp1.SetActive(false);
        Prog9_imgInp2.SetActive(false);
        Prog9_imgInp3.SetActive(false);
        Prog9_imgInp4.SetActive(false);
        Prog9_imgInp5.SetActive(false);

        Prog10_txtInp1.SetActive(false);
        Prog10_txtInp2.SetActive(false);
        Prog10_txtInp3.SetActive(false);
        Prog10_txtInp4.SetActive(false);
        Prog10_txtInp5.SetActive(false);
        Prog10_imgInp1.SetActive(false);
        Prog10_imgInp2.SetActive(false);
        Prog10_imgInp3.SetActive(false);
        Prog10_imgInp4.SetActive(false);
        Prog10_imgInp5.SetActive(false);

        Prog11_txtInp1.SetActive(false);
        Prog11_txtInp2.SetActive(false);
        Prog11_txtInp3.SetActive(false);
        Prog11_txtInp4.SetActive(false);
        Prog11_txtInp5.SetActive(false);
        Prog11_imgInp1.SetActive(false);
        Prog11_imgInp2.SetActive(false);
        Prog11_imgInp3.SetActive(false);
        Prog11_imgInp4.SetActive(false);
        Prog11_imgInp5.SetActive(false);


        Prog12_txtInp1.SetActive(false);
        Prog12_txtInp2.SetActive(false);
        Prog12_txtInp3.SetActive(false);
        Prog12_txtInp4.SetActive(false);
        Prog12_txtInp5.SetActive(false);
        Prog12_imgInp1.SetActive(false);
        Prog12_imgInp2.SetActive(false);
        Prog12_imgInp3.SetActive(false);
        Prog12_imgInp4.SetActive(false);
        Prog12_imgInp5.SetActive(false);

        Prog13_txtInp1.SetActive(false);
        Prog13_txtInp2.SetActive(false);
        Prog13_txtInp3.SetActive(false);
        Prog13_txtInp4.SetActive(false);
        Prog13_txtInp5.SetActive(false);
        Prog13_imgInp1.SetActive(false);
        Prog13_imgInp2.SetActive(false);
        Prog13_imgInp3.SetActive(false);
        Prog13_imgInp4.SetActive(false);
        Prog13_imgInp5.SetActive(false);

    }

    private void desativaProgramacao()
    {
        textoDefautProg1.SetActive(false);
        textoDefautProg2.SetActive(false);
        textoDefautProg3.SetActive(false);
        textoDefautProg4.SetActive(false);
        textoDefautProg5.SetActive(false);
        textoDefautProg6.SetActive(false);
        textoDefautProg7.SetActive(false);
        textoDefautProg8.SetActive(false);
        textoDefautProg9.SetActive(false);
        textoDefautProg10.SetActive(false);
        textoDefautProg11.SetActive(false);
        textoDefautProg12.SetActive(false);
        textoDefautProg13.SetActive(false);
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
        desativaProgramacao();
        abrirComputador = GetComponent<CircleCollider2D>();
        tileN1_1.SetActive(false);
        N1_1.SetActive(false);
        tileN2_1.SetActive(false);
        N2_1.SetActive(false);
        tileN2_2.SetActive(false);
        N2_2.SetActive(false);
        tileN3_1.SetActive(false);
        N3_1.SetActive(false);
        tileN3_2.SetActive(false);
        N3_2.SetActive(false);
        tileN4_1.SetActive(false);
        N4_1.SetActive(false);
        tileN4_2.SetActive(false);
        N4_2.SetActive(false);
        tileN4_3.SetActive(false);
        N4_3.SetActive(false);

        if (instance == null)
        {
            instance = this;
        }
        
    }

    public void buildCode() {
        code = Prog1_txtInp1.GetComponent<Text>().text;
        if (Missao.instance.getObs() == 1)
        {

            if (code == "wifi_start();")
            {
                code = Prog1_txtInp2.GetComponent<Text>().text;
                if (code == "mqtt_app_start();")
                {
                    code = Prog1_txtInp3.GetComponent<Text>().text;
                    if (code == "sensor_chuva_init();")
                    {
                        code = Prog1_txtInp4.GetComponent<Text>().text;
                        if (code == "mqtt_pub_val(sensorChuva_meas());")
                        {
                            code = Prog1_txtInp5.GetComponent<Text>().text;
                            if (code == "vTaskDelay(pdMS_TO_TICKS(1000)*60*10);")
                            {
                                textoOut.GetComponent<Text>().text = "OK, procure a proxima missão";
                                Missao.instance.setObs(0);
                                atual1 = false;
                                atual2 = false;
                                atual3 = false;
                                InventarioSlot.instance.DisableHW();
                                tileN1_0.SetActive(false);
                                N1_0.SetActive(false);
                                tileN1_1.SetActive(true);
                                N1_1.SetActive(true);
                                Missao.instance.playPensar(false);
                                setOkHW(false);
                                countFinal = countFinal + 1;
                                if (countFinal == 13)
                                {
                                    Missao.instance.playFinal();
                                }
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
        code = Prog2_txtInp1.GetComponent<Text>().text;
        if (Missao.instance.getObs() == 2)
        {
            if (code == "motor_start();")
            {
                code = Prog2_txtInp2.GetComponent<Text>().text;
                if (code == "get_sensor_chuva() == true")
                {
                    code = Prog2_txtInp3.GetComponent<Text>().text;
                    if (code == "motor_on();")
                    {
                        code = Prog2_txtInp4.GetComponent<Text>().text;
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
                            countFinal = countFinal + 1;
                            if (countFinal == 13)
                            {
                                Missao.instance.playFinal();
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
        desativaProgramacao();
        build.SetActive(false);
        ota.SetActive(false);
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
                Prog1_txtInp1.SetActive(true);
                Prog1_txtInp2.SetActive(true);
                Prog1_txtInp3.SetActive(true);
                Prog1_txtInp4.SetActive(true);
                Prog1_txtInp5.SetActive(true);
                Prog1_imgInp1.SetActive(true);
                Prog1_imgInp2.SetActive(true);
                Prog1_imgInp3.SetActive(true);
                Prog1_imgInp4.SetActive(true);
                Prog1_imgInp5.SetActive(true);
                textoDefautProg1.SetActive(true);
            }
            else if (Missao.instance.getObs() == 2)
            {
               
                textoDefautProg2.SetActive(true);
            }
            else if (Missao.instance.getObs() == 3)
            {
                
                textoDefautProg3.SetActive(true);
            }
            else if (Missao.instance.getObs() == 4)
            {
                
                textoDefautProg4.SetActive(true);
            }
            else if (Missao.instance.getObs() == 5)
            {
               
                textoDefautProg5.SetActive(true);
            }
            else if (Missao.instance.getObs() == 6)
            {
               
                textoDefautProg6.SetActive(true);
            }
            else if (Missao.instance.getObs() == 7)
            {
               
                textoDefautProg7.SetActive(true);
            }
            else if (Missao.instance.getObs() == 8)
            {
                
                textoDefautProg8.SetActive(true);
            }
            else if (Missao.instance.getObs() == 9)
            {
               
                textoDefautProg9.SetActive(true);
            }
            else if (Missao.instance.getObs() == 10)
            {
               
                textoDefautProg10.SetActive(true);
            }
            else if (Missao.instance.getObs() == 11)
            {
               
                textoDefautProg11.SetActive(true);
            }
            else if (Missao.instance.getObs() == 12)
            {
                
                textoDefautProg12.SetActive(true);
            }
            else if (Missao.instance.getObs() == 13)
            {
               
                textoDefautProg13.SetActive(true);
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
