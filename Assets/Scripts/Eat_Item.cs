using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat_Item : MonoBehaviour {

	private AudioSource[] allAudioSources;


	void Start () {
//	Button btn = yourbutton.GetComponent<Button> ();
//btn.onClick.AddListener (TaskOnClick);
	}

	public void Eat_Food()
	{
		Time.timeScale = 1f;

		Debug.Log ("Eat Item");
	

			


		Text t = GameObject.Find ("title").GetComponent<Text> ();

		GameObject g = GameObject.Find (t.text);


		if (g.tag == "Good_Food") {

				allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

			foreach(AudioSource audioS in allAudioSources){
				audioS.Stop();
			}
	

			GameObject.Find ("Tasty_Voice").GetComponent<AudioSource> ().Play ();



	ScoreManager.score =ScoreManager.score + 1;


			GameObject[] objs;
			objs = GameObject.FindGameObjectsWithTag ("Enemy");
			foreach (GameObject o in objs) {
				//	AudioSource enemyAudio = o.GetComponent <AudioSource> ();
				//	enemyAudio.clip = deathClip;
				//	enemyAudio.Play ();
				//	o.GetComponent<EnemyHealth> ().StartSinking ();
				GameObject.Destroy (o);
				//	o.GetComponent<EnemyHealth> ().Death ();
				//	o.GetComponent<EnemyHealth> ().StartSinking ();
			}

  		
		}else
		{
			allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

			foreach(AudioSource audioS in allAudioSources){
				audioS.Stop();
			}
			GameObject.Find ("Burp").GetComponent<AudioSource> ().Play ();
			if(ScoreManager.score>0){
			ScoreManager.score =ScoreManager.score -1;
			}
	}

		Destroy(g);

		Debug.Log ("eat food");
	//	Opening_Values.move = 1;


		Debug.Log (ScoreManager.score);

		t = GameObject.Find ("ScoreText").GetComponent<Text> ();
		t.text = "Score: " + ScoreManager.score;

	  //  StrengthScript.strength_red -=float.Parse(strength.text)/10; 
	  //  strength_red.fillAmount = StrengthScript.strength_red; 

		//StrengthScript.health_red -=float.Parse(health.text)/10; 
	 //   health_red.fillAmount = StrengthScript.health_red; 

	  //  StrengthScript.smartness_red -= float.Parse(smartness.text)/10; 
	//	smartness_red.fillAmount = StrengthScript.smartness_red; 


		Debug.Log ("werwerw");
		CanvasGroup c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
	
	
		Time.timeScale = 1f;
	}


}
