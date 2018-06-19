using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Skip_Intro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void Skip(){
		SceneManager.LoadScene (0);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
