using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public int score;
    public float jumpForce;
    private Rigidbody2D rb;
    public bool isGrounded;
    public SpriteRenderer sprite;
    public float horizontal;
    public GameObject bullet;
    public float lifes = 3;
    
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }



    private void Update()
    {
        Jump();
        Movement();
        if (transform.position.y <= -21)
        {

            SceneManager.LoadScene("MoreAndIll");
        }
       
    }
    private void Movement()
    {
        Vector3 movement = new Vector3(1, 0, 0) * speed * Time.deltaTime;
        transform.position = transform.position + movement;
        if (horizontal > 0)
        {
            sprite.flipX = false;
        }
        else if (horizontal < 0)
        {
            sprite.flipX = true;
        }
       
    }
    private void shurikenshoot()
    {

    }
    private void Jump()
    {
        //Vector2 jump = new Vector2(0, 1)
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        if(Input.GetKeyDown("r") && Input.GetKeyDown("a") && Input.GetKeyDown("z"))
        {
            SceneManager.LoadScene("Raz!");
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor")
        {
            isGrounded = true;
        }
        if(collision.collider.tag == "Trap" || collision.collider.tag == "Bullet")
        {
            Debug.Log("Hit");
            lifes--;
            



        }
      
      
    } 
}
