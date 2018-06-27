using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class Next : MonoBehaviour {
    public void NextPage()
    {
        GameObject i;
        i = GameObject.Find("Slots - Inventory(Clone)");

        //		Image j =i.transform.GetChild (0).GetChild(0).GetChild(0).GetComponent<Image>();
        //		Debug.Log ("sfsdf" + j.sprite.name);
        //		j =i.transform.GetChild (1).GetChild(0).GetChild(0).GetComponent<Image>();
        //		Debug.Log ("sfsdf" + j.sprite.name);
        //		j =i.transform.GetChild (2).GetChild(0).GetChild(0).GetComponent<Image>();
        //		Debug.Log ("sfsdf" + j.sprite.name);
        //		j =i.transform.GetChild (3).GetChild(0).GetChild(0).GetComponent<Image>();
        //		Debug.Log ("sfsdf" + j.sprite.name);
        //		j =i.transform.GetChild (4).GetChild(0).GetChild(0).GetComponent<Image>();
        //		Debug.Log ("sfsdf" + j.sprite.name);

        int sceneID = SceneManager.GetActiveScene().buildIndex;


        SceneManager.LoadScene(sceneID + 1);





    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
