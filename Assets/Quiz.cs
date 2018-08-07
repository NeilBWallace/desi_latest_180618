using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour {


    void GiveUsEnergy()
    {
      

        CanvasGroup d = GameObject.Find("Energy_Text").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }
    void ToSee()
    {

    }

    void ToHeal()
    {

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
