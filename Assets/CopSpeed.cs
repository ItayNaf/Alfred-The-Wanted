using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopSpeed : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(1, 0, 0) * speed * Time.deltaTime;
        transform.position = transform.position + movement;
    }
}
