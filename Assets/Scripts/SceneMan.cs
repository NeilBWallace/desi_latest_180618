using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMan : MonoBehaviour {
    public void LoadIntro2()
    {
        SceneManager.LoadScene(2);
    }
    public void sceneman(){
		SceneManager.LoadScene (8);
	}

    public void GoToIntro()
    {
        SceneManager.LoadScene(0);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
