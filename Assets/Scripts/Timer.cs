using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    public Text displayContagem;

    public float contagem = 300.0f;
    void Start()
    {
        
    }
    void Update()
    {
        if (contagem > 0.0f)
        {
            contagem -= Time.deltaTime;
            displayContagem.text = contagem.ToString("F2");
        }

        else
        {
            displayContagem.text = "Tempo Acabou!";
        }

        if (contagem <= 0.0f)
        {
            SceneManager.LoadScene("Game Over");
        }
        
    }

}
