using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Erros : MonoBehaviour
{
    public int erros = 0;

    public void Errou()
    {
        erros = erros + 1;
        return;
    }

    private void Update()
    {
        if (erros >= 3)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
