using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMan1 : MonoBehaviour {


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void sceneman(){
	
		SceneManager.LoadScene (5);
	}

    public void playgame()
    {

        SceneManager.LoadScene(3);
    }

    public void quit()
    {

        Application.Quit();
    }


    // Use this for initialization
    void Start () {
		
	}
	
	

}
