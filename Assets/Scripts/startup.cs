using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class startup : MonoBehaviour {

	public Transform spawnPos;
	public GameObject spawnee;
	public GameObject g;
	public Transform[] spawnLocations;
	public static GameObject[] FoodSpawns;
	public static int pos=0;
	public int x;int y;int z;
	// Use this for initialization
	void Start () {

		x = 0;y = 0;z = 0;
		int f1x = 288;int f1y = 3;int f1z = 183;
		int f2x = 308;int f2y=4; int f2z=181;
		int f3x = 287;int f3y=3; int f3z=136;
		int f4x = 238;int f4y=3; int f4z=139;
		int f5x = 241;int f5y=2; int f5z=141;
		int f6x = 291;int f6y=2; int f6z=133;
		int f7x = 291;int f7y=3; int f7z=152;
		int f8x = 302;int f8y=3; int f8z=166;



	


		if (Application.loadedLevelName == "parental_setup") {

	//		Vector3 v = new Vector3 (100f, -100f, 3);
	
	//		spawnPos.position = v;
			for (int i = 1; i <= Opening_Values.foods_chosen; i++){
				spawnPos.Translate (0, 0, pos);
		
				if (i == 1) {
					x = f1x;
					y = f1y;
					z = f1z;
				}

				if (i == 2) {
					x = f2x;
					y = f2y;
					z = f2z;
				}

				if (i == 3) {
						x = f3x;
					y = f3y;
				z = f3z;
					}

				if (i == 4) {
					x = f4x;
					y = f4y;
					z = f4z;
				}

				if (i == 5) {
					x = f5x;
					y = f5y;
					z = f5z;
				}

				if (i == 6) {
					x = f6x;
					y = f6y;
					z = f6z;
				}

				if (i == 7) {
					x = f7x;
					y = f7y;
					z = f7z;
				}
				if (i == 8) {
					x = f8x;
					y = f8y;
					z = f8z;
				}

				g = (GameObject)Instantiate (spawnee, new Vector3(x,y,z), spawnPos.rotation);
				g.name = Opening_Values.foodObjs [i];
				g.GetComponent<stats> ().fd = Opening_Values.foodDescriptions [i];
				g.GetComponent<stats> ().food_group = Opening_Values.foodGroup [i];
				g.GetComponent<AudioSource> ().name= Opening_Values.foodObjs [i];

				Debug.Log ("food description" + Opening_Values.foodDescriptions [i]);
				pos=pos +3;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
