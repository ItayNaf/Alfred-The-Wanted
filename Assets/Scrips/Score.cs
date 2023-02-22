using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject player;
    
    
    private void Start()
    {
         
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.name == "Player")
        {

            player.GetComponent<PlayerMovement>().lifes++;
            Destroy(this.gameObject);
            


        }
    }

}