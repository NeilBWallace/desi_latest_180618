﻿using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject
{
	public class GameOverManager : MonoBehaviour
	{
		public PlayerHealth playerHealth;       // Reference to the player's health.


		Animator anim;                          // Reference to the animator component.


		void Awake ()
		{
			// Set up the reference.
			anim = GetComponent <Animator> ();
		}


		void Update ()
		{



            if (ScoreManager.score == 5)
            {
               

                    CanvasGroup c = GameObject.Find("Market_Panel").GetComponent<CanvasGroup>();
                    c.alpha = 1;

                if (Application.loadedLevelName == "marketplace")
                {
                    GameObject.Find("Quickly").GetComponent<Text>().text = "Well done. Eating proteins/dairy has helped heal Desi's wings. Are you ready to fly a little?";

                }
                if (Application.loadedLevelName == "magic_glade")
                    {
                        GameObject.Find("Quickly").GetComponent<Text>().text = "Well done. Eating carbohydrates has given Desi strength to fly long distances. Are you ready to fly a little?";
                    }

                 
            }


                // If the player has run out of health...
                if (playerHealth.currentHealth <= 0)
                {

             

                    // ... tell the animator the game is over.
                    anim.SetTrigger("GameOver");
                }
            }
		}
	}


