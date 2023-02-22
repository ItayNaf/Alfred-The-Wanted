using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnMore : MonoBehaviour
{
    public GameObject player;
    void Start()
    {

    }

    
    void Update()
    {
        float lifes = player.GetComponent<PlayerMovement>().lifes;
        if (lifes <= 0)
        {
            SceneManager.LoadScene("MoreAndIll");
        }
    }
}
