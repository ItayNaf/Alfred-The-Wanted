using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnCop : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float lifes = player.GetComponent<PlayerMovement>().lifes;
        if(lifes <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
