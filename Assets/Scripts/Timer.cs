using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//#------------------------------------------------------#
//#------------------------------------------------------#
//#   Usabilidade, Desenvolvimento Web, Mobile e Jogos   #
//#               -- SCRIPT TEMPORIZADOR--               #
//#          Desenvolvido para Castelo de Euler          #
//#------------------------------------------------------#
//#------------------------------------------------------#

public class Timer : MonoBehaviour
{ // Variável privada do tipo float para contador o tempo

    public Text timeLevel_txt;
    private float timeLevel;
    //Variável que passará valor de verdadeiro ou falso caso isso ocorra no jogo
    public static bool stopTime;
    void Start()
    {
        stopTime = false;   
    }

    void Update()
    {

        //Se o stopTime for falso ele conta o tempo

        if (stopTime==false)
        {
            timeLevel = timeLevel + Time.deltaTime;
            timeLevel_txt.text = timeLevel.ToString("0");
        }
    }
}
