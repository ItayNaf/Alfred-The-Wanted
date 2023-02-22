using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text Text;
    private PlayerMovement Player;
    void Start()
    {
        Text = GetComponent<Text>();
        Player = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = Player.lifes.ToString();
        
    }
}
