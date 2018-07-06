using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {


  public   void GoBack()
    {
        CanvasGroup c = GameObject.Find("Quickly").GetComponent<CanvasGroup>();
        c.alpha = 0;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
