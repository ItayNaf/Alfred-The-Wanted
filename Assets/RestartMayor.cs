using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMayor : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("MayorAndIll");
    }
}
