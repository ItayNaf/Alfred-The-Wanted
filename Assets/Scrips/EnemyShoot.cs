using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    bool canshoot = true;
    public GameObject bullet;
    public Transform player, shootPos;
    public float range, walkspeed, timeBTWShots, shootSpeed;
    private float distoplayer;
    private Rigidbody2D rb;
    void Start()
    {
      
    }

    void Update()
    {
        distoplayer = Vector2.Distance(transform.position, player.position);
        if (distoplayer <= range)
        {
            if(canshoot ==  true)
            {
               
                StartCoroutine(shoot());
                
            }
            
        }
    }
    IEnumerator shoot()
    {
        canshoot = false;
        yield return new WaitForSeconds(timeBTWShots);
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * Time.fixedDeltaTime, 0);
        
        canshoot = true; 
    }
}
