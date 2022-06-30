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
    public GameObject Prog12_imgInp1, Prog12_imgInp2, Prog12_imgInp3, Prog12_imgInp4;
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
    public GameObject Prog12_txtInp1, Prog12_txtInp2, Prog12_txtInp3, Prog12_txtInp4;
    public GameObject Prog13_txtInp1, Prog13_txtInp2, Prog13_txtInp3, Prog13_txtInp4, Prog13_txtInp5;

    public GameObject textoOut;   
    public GameObject computador;
    public GameObject build;
    public GameObject saiHW;
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
        Prog12_imgInp1.SetActive(false);
        Prog12_imgInp2.SetActive(false);
        Prog12_imgInp3.SetActive(false);
        Prog12_imgInp4.SetActive(false);

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
    private void missaoConcluida() {
        textoOut.GetComponent<Text>().text = "OK, procure a proxima missão";
        Missao.instance.setObs(0);
        limpaHWs();
        InventarioSlot.instance.DisableHW();
        Missao.instance.playPensar(false);
        setOkHW(false);
        countFinal = countFinal + 1;
        if (countFinal == 13)
        {
            Missao.instance.playFinal();
        }

    }
    public void buildCode() {
        
        if (Missao.instance.getObs() == 1)
        {
            code = Prog1_txtInp1.GetComponent<Text>().text;
            if (code == "xTaskSensorsHandle")
            {
                code = Prog1_txtInp2.GetComponent<Text>().text;
                if (code == "valChuva")
                {
                    code = Prog1_txtInp3.GetComponent<Text>().text;
                    if (code == "sensorChuva")
                    {
                        code = Prog1_txtInp4.GetComponent<Text>().text;
                        if (code == "valChuva")
                        {
                            code = Prog1_txtInp5.GetComponent<Text>().text;
                            if (code == "600")
                            {
                                missaoConcluida();
                                tileN1_0.SetActive(false);
                                N1_0.SetActive(false);
                                tileN1_1.SetActive(true);
                                N1_1.SetActive(true);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 2)
        {
            code = Prog2_txtInp1.GetComponent<Text>().text;
            if (code == "vTaskOutput")
            {
                code = Prog2_txtInp2.GetComponent<Text>().text;
                if (code == "sensorChuva_meas();")
                {
                    code = Prog2_txtInp3.GetComponent<Text>().text;
                    if (code == "valChuva")
                    {
                        code = Prog2_txtInp4.GetComponent<Text>().text;
                        if (code == "motorSet_rot(valChuva);")
                        {
                            code = Prog2_txtInp5.GetComponent<Text>().text;
                            if (code == "5")
                            {
                                missaoConcluida();
                                tileN1_1.SetActive(false);
                                N1_1.SetActive(false);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 3)
        {
            code = Prog3_txtInp1.GetComponent<Text>().text;
            if (code == "bth")
            {
                code = Prog3_txtInp2.GetComponent<Text>().text;
                if (code == "sensorUmd")
                {
                    code = Prog3_txtInp3.GetComponent<Text>().text;
                    if (code == "sensorUmid")
                    {
                        code = Prog3_txtInp4.GetComponent<Text>().text;
                        if (code == "bthPub")
                        {
                            code = Prog3_txtInp5.GetComponent<Text>().text;
                            if (code == "pdMS_TO_TICKS(1000)")
                            {
                                missaoConcluida();
                                tileN2_0.SetActive(false);
                                N2_0.SetActive(false);
                                tileN2_1.SetActive(true);
                                N2_1.SetActive(true);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 4)
        {
            code = Prog4_txtInp1.GetComponent<Text>().text;
            if (code == "TaskHandle_t")
            {
                code = Prog4_txtInp2.GetComponent<Text>().text;
                if (code == "vTaskOutput")
                {
                    code = Prog4_txtInp3.GetComponent<Text>().text;
                    if (code == "xTaskCreate")
                    {
                        code = Prog4_txtInp4.GetComponent<Text>().text;
                        if (code == "xTaskCreate")
                        {
                            code = Prog4_txtInp5.GetComponent<Text>().text;
                            if (code == "512")
                            {
                                missaoConcluida();
                                tileN2_1.SetActive(false);
                                N2_1.SetActive(false);
                                tileN2_2.SetActive(true);
                                N2_2.SetActive(true);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 5)
        {
            code = Prog5_txtInp1.GetComponent<Text>().text;
            if (code == "#include \"main.h\"")
            {
                code = Prog5_txtInp2.GetComponent<Text>().text;
                if (code == "valUmd")
                {
                    code = Prog5_txtInp3.GetComponent<Text>().text;
                    if (code == "70")
                    {
                        code = Prog5_txtInp4.GetComponent<Text>().text;
                        if (code == "irrigSet_state")
                        {
                            code = Prog5_txtInp5.GetComponent<Text>().text;
                            if (code == "irrigSet_state")
                            {
                                missaoConcluida();
                                tileN2_2.SetActive(false);
                                N2_2.SetActive(false);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 6)
        {
            code = Prog6_txtInp1.GetComponent<Text>().text;
            if (code == "valCor;")
            {
                code = Prog6_txtInp2.GetComponent<Text>().text;
                if (code == "bth_start();")
                {
                    code = Prog6_txtInp3.GetComponent<Text>().text;
                    if (code == "sensorCor")
                    {
                        code = Prog6_txtInp4.GetComponent<Text>().text;
                        if (code == "sensorCor_meas();")
                        {
                            code = Prog6_txtInp5.GetComponent<Text>().text;
                            if (code == "bthPub_val")
                            {
                                missaoConcluida();
                                tileN3_0.SetActive(false);
                                N3_0.SetActive(false);
                                tileN3_1.SetActive(true);
                                N3_1.SetActive(true);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 7)
        {
            code = Prog7_txtInp1.GetComponent<Text>().text;
            if (code == "valTemp")
            {
                code = Prog7_txtInp2.GetComponent<Text>().text;
                if (code == "sensorTempUmd_init();")
                {
                    code = Prog7_txtInp3.GetComponent<Text>().text;
                    if (code == "CONFIG_TASK_PRIO_VERY_LOW")
                    {
                        code = Prog7_txtInp4.GetComponent<Text>().text;
                        if (code == "sensorTempUmd_measTemp();")
                        {
                            code = Prog7_txtInp5.GetComponent<Text>().text;
                            if (code == "sensorTempUmd_measUmd();")
                            {
                                missaoConcluida();
                                tileN3_1.SetActive(false);
                                N3_1.SetActive(false);
                                tileN3_2.SetActive(true);
                                N3_2.SetActive(true);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 8)
        {
            code = Prog8_txtInp1.GetComponent<Text>().text;
            if (code == "1")
            {
                code = Prog8_txtInp2.GetComponent<Text>().text;
                if (code == "releSet_state")
                {
                    code = Prog8_txtInp3.GetComponent<Text>().text;
                    if (code == "0")
                    {
                        code = Prog8_txtInp4.GetComponent<Text>().text;
                        if (code == "releSet_state")
                        {
                            code = Prog8_txtInp5.GetComponent<Text>().text;
                            if (code == "0")
                            {
                                missaoConcluida();
                                tileN3_2.SetActive(false);
                                N3_2.SetActive(false);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 9)
        {
            code = Prog9_txtInp1.GetComponent<Text>().text;
            if (code == "\"Ronaldo\"")
            {
                code = Prog9_txtInp2.GetComponent<Text>().text;
                if (code == "\"ronaldo12345\"")
                {
                    code = Prog9_txtInp3.GetComponent<Text>().text;
                    if (code == "RTC_init();")
                    {
                        code = Prog9_txtInp4.GetComponent<Text>().text;
                        if (code == "2")
                        {
                            code = Prog9_txtInp5.GetComponent<Text>().text;
                            if (code == "120")
                            {
                                missaoConcluida();
                                tileN4_0.SetActive(false);
                                N4_0.SetActive(false);
                                tileN4_1.SetActive(true);
                                N4_1.SetActive(true);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 10)
        {
            code = Prog10_txtInp1.GetComponent<Text>().text;
            if (code == "rele_init();")
            {
                code = Prog10_txtInp2.GetComponent<Text>().text;
                if (code == "releSet_state")
                {
                    code = Prog10_txtInp3.GetComponent<Text>().text;
                    if (code == "3")
                    {
                        code = Prog10_txtInp4.GetComponent<Text>().text;
                        if (code == "1")
                        {
                            code = Prog10_txtInp5.GetComponent<Text>().text;
                            if (code == "300")
                            {
                                missaoConcluida();
                                tileN4_1.SetActive(false);
                                N4_1.SetActive(false);
                                tileN4_2.SetActive(true);
                                N4_2.SetActive(true);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 11)
        {
            code = Prog11_txtInp1.GetComponent<Text>().text;
            if (code == "valRTC_min;")
            {
                code = Prog11_txtInp2.GetComponent<Text>().text;
                if (code == "buzzer_init();")
                {
                    code = Prog11_txtInp3.GetComponent<Text>().text;
                    if (code == "buzzerSet_state")
                    {
                        code = Prog11_txtInp4.GetComponent<Text>().text;
                        if (code == "1")
                        {
                            code = Prog11_txtInp5.GetComponent<Text>().text;
                            if (code == "300")
                            {
                                missaoConcluida();
                                tileN4_2.SetActive(false);
                                N4_2.SetActive(false);
                                tileN4_3.SetActive(true);
                                N4_3.SetActive(true);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 12)
        {
            code = Prog12_txtInp1.GetComponent<Text>().text;
            if (code == "ble_start();")
            {
                code = Prog12_txtInp2.GetComponent<Text>().text;
                if (code == "blePub_val")
                {
                    code = Prog12_txtInp3.GetComponent<Text>().text;
                    if (code == "blePub_val")
                    {
                        code = Prog12_txtInp4.GetComponent<Text>().text;
                        if (code == "blePub_val")
                        {
                            missaoConcluida();
                            tileN4_3.SetActive(false);
                            N4_3.SetActive(false);
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
            }
        }
        if (Missao.instance.getObs() == 13)
        {
            code = Prog13_txtInp1.GetComponent<Text>().text;
            if (code == "xTaskSensorsHandle")
            {
                code = Prog13_txtInp2.GetComponent<Text>().text;
                if (code == "valChuva")
                {
                    code = Prog13_txtInp3.GetComponent<Text>().text;
                    if (code == "sensorChuva")
                    {
                        code = Prog13_txtInp4.GetComponent<Text>().text;
                        if (code == "valChuva")
                        {
                            code = Prog13_txtInp5.GetComponent<Text>().text;
                            if (code == "600")
                            {
                                missaoConcluida();
                                tileN5.SetActive(false);
                                N5.SetActive(false);
                            }
                            else
                            {
                                textoOut.GetComponent<Text>().text = "A entrada 5 está errada";
                            }
                        }
                        else
                        {
                            textoOut.GetComponent<Text>().text = "A entrada 4 está errada";
                        }
                    }
                    else
                    {
                        textoOut.GetComponent<Text>().text = "A entrada 3 está errada";
                    }
                }
                else
                {
                    textoOut.GetComponent<Text>().text = "A entrada 2 está errada";
                }
            }
            else
            {
                textoOut.GetComponent<Text>().text = "A entrada 1 está errada";
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
        InventarioSlot.instance.DisableHW();
        txtHW.SetActive(false);
        saiHW.SetActive(false);
        txtHW.SetActive(false);
        computador.SetActive(false);
        textoOut.SetActive(false);
        desativaInput();
        desativaProgramacao();
        build.SetActive(false);
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
                Prog2_txtInp1.SetActive(true);
                Prog2_txtInp2.SetActive(true);
                Prog2_txtInp3.SetActive(true);
                Prog2_txtInp4.SetActive(true);
                Prog2_txtInp5.SetActive(true);
                Prog2_imgInp1.SetActive(true);
                Prog2_imgInp2.SetActive(true);
                Prog2_imgInp3.SetActive(true);
                Prog2_imgInp4.SetActive(true);
                Prog2_imgInp5.SetActive(true);
                textoDefautProg2.SetActive(true);
            }
            else if (Missao.instance.getObs() == 3)
            {
                Prog3_txtInp1.SetActive(true);
                Prog3_txtInp2.SetActive(true);
                Prog3_txtInp3.SetActive(true);
                Prog3_txtInp4.SetActive(true);
                Prog3_txtInp5.SetActive(true);
                Prog3_imgInp1.SetActive(true);
                Prog3_imgInp2.SetActive(true);
                Prog3_imgInp3.SetActive(true);
                Prog3_imgInp4.SetActive(true);
                Prog3_imgInp5.SetActive(true);
                textoDefautProg3.SetActive(true);
            }
            else if (Missao.instance.getObs() == 4)
            {
                Prog4_txtInp1.SetActive(true);
                Prog4_txtInp2.SetActive(true);
                Prog4_txtInp3.SetActive(true);
                Prog4_txtInp4.SetActive(true);
                Prog4_txtInp5.SetActive(true);
                Prog4_imgInp1.SetActive(true);
                Prog4_imgInp2.SetActive(true);
                Prog4_imgInp3.SetActive(true);
                Prog4_imgInp4.SetActive(true);
                Prog4_imgInp5.SetActive(true);
                textoDefautProg4.SetActive(true);
            }
            else if (Missao.instance.getObs() == 5)
            {
                Prog5_txtInp1.SetActive(true);
                Prog5_txtInp2.SetActive(true);
                Prog5_txtInp3.SetActive(true);
                Prog5_txtInp4.SetActive(true);
                Prog5_txtInp5.SetActive(true);
                Prog5_imgInp1.SetActive(true);
                Prog5_imgInp2.SetActive(true);
                Prog5_imgInp3.SetActive(true);
                Prog5_imgInp4.SetActive(true);
                Prog5_imgInp5.SetActive(true);
                textoDefautProg5.SetActive(true);
            }
            else if (Missao.instance.getObs() == 6)
            {
                Prog6_txtInp1.SetActive(true);
                Prog6_txtInp2.SetActive(true);
                Prog6_txtInp3.SetActive(true);
                Prog6_txtInp4.SetActive(true);
                Prog6_txtInp5.SetActive(true);
                Prog6_imgInp1.SetActive(true);
                Prog6_imgInp2.SetActive(true);
                Prog6_imgInp3.SetActive(true);
                Prog6_imgInp4.SetActive(true);
                Prog6_imgInp5.SetActive(true);
                textoDefautProg6.SetActive(true);
            }
            else if (Missao.instance.getObs() == 7)
            {
                Prog7_txtInp1.SetActive(true);
                Prog7_txtInp2.SetActive(true);
                Prog7_txtInp3.SetActive(true);
                Prog7_txtInp4.SetActive(true);
                Prog7_txtInp5.SetActive(true);
                Prog7_imgInp1.SetActive(true);
                Prog7_imgInp2.SetActive(true);
                Prog7_imgInp3.SetActive(true);
                Prog7_imgInp4.SetActive(true);
                Prog7_imgInp5.SetActive(true);
                textoDefautProg7.SetActive(true);
            }
            else if (Missao.instance.getObs() == 8)
            {
                Prog8_txtInp1.SetActive(true);
                Prog8_txtInp2.SetActive(true);
                Prog8_txtInp3.SetActive(true);
                Prog8_txtInp4.SetActive(true);
                Prog8_txtInp5.SetActive(true);
                Prog8_imgInp1.SetActive(true);
                Prog8_imgInp2.SetActive(true);
                Prog8_imgInp3.SetActive(true);
                Prog8_imgInp4.SetActive(true);
                Prog8_imgInp5.SetActive(true);
                textoDefautProg8.SetActive(true);
            }
            else if (Missao.instance.getObs() == 9)
            {
                Prog9_txtInp1.SetActive(true);
                Prog9_txtInp2.SetActive(true);
                Prog9_txtInp3.SetActive(true);
                Prog9_txtInp4.SetActive(true);
                Prog9_txtInp5.SetActive(true);
                Prog9_imgInp1.SetActive(true);
                Prog9_imgInp2.SetActive(true);
                Prog9_imgInp3.SetActive(true);
                Prog9_imgInp4.SetActive(true);
                Prog9_imgInp5.SetActive(true);
                textoDefautProg9.SetActive(true);
            }
            else if (Missao.instance.getObs() == 10)
            {
                Prog10_txtInp1.SetActive(true);
                Prog10_txtInp2.SetActive(true);
                Prog10_txtInp3.SetActive(true);
                Prog10_txtInp4.SetActive(true);
                Prog10_txtInp5.SetActive(true);
                Prog10_imgInp1.SetActive(true);
                Prog10_imgInp2.SetActive(true);
                Prog10_imgInp3.SetActive(true);
                Prog10_imgInp4.SetActive(true);
                Prog10_imgInp5.SetActive(true);
                textoDefautProg10.SetActive(true);
            }
            else if (Missao.instance.getObs() == 11)
            {
                Prog11_txtInp1.SetActive(true);
                Prog11_txtInp2.SetActive(true);
                Prog11_txtInp3.SetActive(true);
                Prog11_txtInp4.SetActive(true);
                Prog11_txtInp5.SetActive(true);
                Prog11_imgInp1.SetActive(true);
                Prog11_imgInp2.SetActive(true);
                Prog11_imgInp3.SetActive(true);
                Prog11_imgInp4.SetActive(true);
                Prog11_imgInp5.SetActive(true);
                textoDefautProg11.SetActive(true);
            }
            else if (Missao.instance.getObs() == 12)
            {
                Prog12_txtInp1.SetActive(true);
                Prog12_txtInp2.SetActive(true);
                Prog12_txtInp3.SetActive(true);
                Prog12_txtInp4.SetActive(true);
                Prog12_imgInp1.SetActive(true);
                Prog12_imgInp2.SetActive(true);
                Prog12_imgInp3.SetActive(true);
                Prog12_imgInp4.SetActive(true);
                textoDefautProg12.SetActive(true);
            }
            else if (Missao.instance.getObs() == 13)
            {
                Prog13_txtInp1.SetActive(true);
                Prog13_txtInp2.SetActive(true);
                Prog13_txtInp3.SetActive(true);
                Prog13_txtInp4.SetActive(true);
                Prog13_txtInp5.SetActive(true);
                Prog13_imgInp1.SetActive(true);
                Prog13_imgInp2.SetActive(true);
                Prog13_imgInp3.SetActive(true);
                Prog13_imgInp4.SetActive(true);
                Prog13_imgInp5.SetActive(true);
                textoDefautProg13.SetActive(true);
            }

            computador.SetActive(true);
            textoOut.SetActive(true);
            build.SetActive(true);
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
    public void limpaHWs() {
        atual1 = false;
        atual2 = false;
        atual3 = false;
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
