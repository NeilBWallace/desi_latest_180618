using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Opening_Values : MonoBehaviour {

	//public static int move =0;

	public static int foods_chosen = 0;

	public static string selectedfood;
	public static int selectedfoodhealth;
	public static int selectedfoodsmartness;
	public static int selectedfoodstrength;
	public static string selectedfoodfd;
	public static string selectedfoodfoodgroup;

	public static string[] foodObjs = {"","","","","","","","","" };
	public static string[] foodDescriptions= {"","","","","","","","","" };
	public static string[] foodGroup= {"","","","","","","","","" };

    public static string[] protein_dairy_name = { "", "", "", "", "" };
    public static string[] vegetable_fruit_name = { "", "", "", "", "" };
    public static string[] carbohydrates_name = { "", "", "", "", "" };
    public static string[] sweets_fats_name = { "", "", "", "", "" };

    public static string[] protein_dairy_description= { "", "", "", "", "" };
    public static string[] vegetable_fruit_description = { "", "", "", "", "" };
    public static string[] carbohydrates_description = { "", "", "", "", "" };
    public static string[] sweets_fats_description = { "", "", "", "", "" };



    [SerializeField]
	private GameObject desi;



	[SerializeField]
	private Text ot;
	// Use this for initialization
	void Start () {
		
		//CanvasGroup c =foodpanel.GetComponent<CanvasGroup> ();
	//	c.alpha = 0;



	//	choose_food_panel.SetActive (false);	
	//	Eat_Food_Panel.SetActive (false);
	//	desi.SetActive (false);
	//	ot.GetComponent<Text> ().text = "Parents: Please select three food items from the scrollable food bank" +
		//	" to load the scene. -->";
	//	fd.color= new Color(fd.color.r,fd.color.g,fd.color.b,Mathf.Sin(Time.time*2));


	}

	




			


}
