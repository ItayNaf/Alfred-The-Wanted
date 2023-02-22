using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartKlair : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("KlairAndIll");
    }
}
