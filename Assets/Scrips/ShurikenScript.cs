using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenScript : MonoBehaviour
{
    public float speed;
    private PlayerMovement player;
    Vector2 currentlocation;
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        
    }
    void Update()
    {
        // Vector3 newshurikendirection = new Vector3(player.horizontal, 0, 0);
    }
    private void Shurikenmove(){
        if(player.sprite.flipX == true)
        {
            transform.position = (Vector2.right * speed*Time.deltaTime);
        }
        else if(player.sprite.flipX == false)
        {
            transform.position = (Vector2.left * speed * Time.deltaTime);
        }
    }


}
