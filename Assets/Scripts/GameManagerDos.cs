using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerDos : MonoBehaviour
{

    //** Declare a variable for the score value and set it to 0 **//
    int score = 0;
    // Declare a variable for the lives value and set it to 5 **//
    int lives = 3;
    
    
    GameObject player;
   
    void Start()
    {

        //** Uncomment the Debug Log below and add the appropriate variable names to show the starting score and lives in the console **//
       Debug.Log("Score: " + score + "\n" + "Lives: " + lives ); 
        
        
        player = GameObject.Find("Player");
        
    }

   
    void Update()
    {

    }

    public void UpdateLives(int value)
    {
        //** Uncomment the line below and add the appropriate variable name for lives **//
        lives += value;

        HealthBar healthBar = GameObject.FindObjectOfType<HealthBar>();
        healthBar.SetValue(lives);

        //** Uncomment the if statement below and fix the comments
       
            // add the appropriate variable name into the if statement for lives
            if (lives < 1)
                {
                    // Create a Debug Log below that displays "Game Over" in the console
                    Debug.Log("Game Over!");

                    // Set the variable for lives equal to 0 
                    lives = 0;
                    
                    Destroy(player);
                }

        //** Uncomment the line below after adding the appropriate variable name in the Debug Log
        Debug.Log("Lives: " + lives);
    }

    public void AddScore(int value)
    {
        //** Uncomment the line below and add the appropriate variable name for score **//
        score += value;
        
        //** Uncomment the line below after adding the appropriate variable name in the Debug Log **//
        Debug.Log("Score: " + score );
    } 
}