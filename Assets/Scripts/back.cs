using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class back : MonoBehaviour {




    public void Back()
    {

        Time.timeScale = 1f;

        GameObject[] objs;
        //	objs = GameObject.FindGameObjectsWithTag ("Good_Food");
        //	foreach (GameObject o in objs) {
        //		GameObject.Find (o.name ).GetComponent<AudioSource> ().Stop ();
        //	}

        //	objs = GameObject.FindGameObjectsWithTag ("Bad_Food");
        //	foreach (GameObject o in objs) {
        //		GameObject.Find (o.name ).GetComponent<AudioSource> ().Stop ();	
        //	}

        if (Application.loadedLevelName == "marketplace")
        {
            CanvasGroup d = GameObject.Find("Food_Panel").GetComponent<CanvasGroup>();
            d.alpha = 0;

            d = GameObject.Find("Market_Panel").GetComponent<CanvasGroup>();
            d.alpha = 0;

        }

        //GameObject.Find ("Back").GetComponent<AudioSource> ().Play ();

        if (ScoreManager.score == 5)
        {
            if (Application.loadedLevelName == "marketplace")
            {
                SceneManager.LoadScene("Magic_Glade");
            }

            Debug.Log('x' + Application.loadedLevelName);
            if (Application.loadedLevelName == "magic_glade")
            {
                Debug.Log("werwer");
                SceneManager.LoadScene("thebridge");
            }
        }
        CanvasGroup c = GameObject.Find("Food_Panel").GetComponent<CanvasGroup>();
        c.alpha = 0;

        c = GameObject.Find("Market_Panel").GetComponent<CanvasGroup>();
        c.alpha = 0;

    }
    }
	
  
