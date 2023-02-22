//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class HealthScript : MonoBehaviour
//{
//    public float starterHealth;
//    public GameObject player;
//    public GameObject diePEffect;
//    voidStart()
//    {
//        player.GetComponent<PlayerMovement>().lifes = starterHealth;
//    }

//    // Update is called once per frame
//    voidUpdate()
//    {
        
//    }
//    public void TakeDamage(float damage)
//    {
//        player.GetComponent<PlayerMovement>().lifes -= damage;

//        if (player.GetComponent<PlayerMovement>().lifes <= 0)
//        {
//            Die();
//        }

//    }
//    void Die()
//    {
//        if(diePEffect != null)
//        {
//            Instantiate(diePEffect, transform.position, Quaternion.identity);
//        }
//        Destroy(gameObject);
//    }
//}
