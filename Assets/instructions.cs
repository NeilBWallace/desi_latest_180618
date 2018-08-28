using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour {

	public void RunInstructions(){
		SceneManager.LoadScene (1);
	
	}
	// Use this for initialization
	void Start () {
        GameObject.Find("Click").GetComponent<AudioSource>().Play();

    }

    // Update is called once per frame
    void Update () {
		
	}
}
