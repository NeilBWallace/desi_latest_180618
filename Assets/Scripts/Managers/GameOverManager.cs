using UnityEngine;
using UnityEngine.UI;

namespace CompleteProject
{
    public class GameOverManager : MonoBehaviour
    {
        public PlayerHealth playerHealth;       // Reference to the player's health.


        Animator anim;                          // Reference to the animator component.


        void Awake()
        {
            // Set up the reference.
            anim = GetComponent<Animator>();
        }


        void Update()
        {



            if (ScoreManager.score == 5)
            {
                Debug.Log("Score" + ScoreManager.score);

                CanvasGroup c = GameObject.Find("End_Panel").GetComponent<CanvasGroup>();
                c.alpha = 1;


                if (Application.loadedLevelName == "bridge2")
                {
                    GameObject.Find("End_Text").GetComponent<Text>().text = "Well done. You have found 5 sweets/fats. The crazy Troll lets you pass over the bridge. I wonder where you will go next!?";

                }




                if (Application.loadedLevelName == "marketplace")
                {
                    GameObject.Find("End_Text").GetComponent<Text>().text = "Well done. Eating proteins/dairy has helped heal Desi's wings. Are you ready to fly a little?";

                }
                if (Application.loadedLevelName == "magic_glade")
                {
                    GameObject.Find("End_Text").GetComponent<Text>().text = "Well done. Eating carbohydrates has given Desi strength to fly long distances. Are you ready to fly a little?";
                }

                if (Application.loadedLevelName == "orchard")
                {

                    SceneMan1.finished = 1;

                    GameObject.Find("End_Text").GetComponent<Text>().text = "Well done. Desi is able to fly home! You have completed your adventure!";
                }
            }
            if (Application.loadedLevelName != "marketplace")
            {

                // If the player has run out of health...
                if (playerHealth.currentHealth <= 0)
                {

                    Debug.Log("No health");

                    // ... tell the animator the game is over.
                    anim.SetTrigger("GameOver");
                }
            }
        }
    }
	}


