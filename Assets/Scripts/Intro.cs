using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Intro: MonoBehaviour {

	public void sceneman(){
	
		SceneManager.LoadScene (1);
	}

	public void LoadInstructions(){
		//Load Instructions scene
		SceneManager.LoadScene (13);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
