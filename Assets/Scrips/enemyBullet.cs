using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyBullet : MonoBehaviour
{
    public float dieTime, damage;
    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            player.GetComponent<PlayerMovement>().lifes--;

            Destroy(gameObject);

        }

    }
    void Start()
    {
        StartCoroutine(CountDownTimer());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator CountDownTimer()
    {
        yield return new WaitForSeconds(dieTime);
        Die();
    }
    void Die()
    {

        Destroy(gameObject);
    }
   


}
