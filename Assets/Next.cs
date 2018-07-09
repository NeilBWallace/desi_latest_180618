using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class Next : MonoBehaviour {

    public ItemOnObject item;

       public void set_description(int index,string v )
    {
      
        string k = SceneManager.GetActiveScene().name;
   
        if (k == "market")
        {
            Opening_Values.protein_dairy_description[index] =v;
        }
        else if (k == "magic glade")
        {
            Opening_Values.carbohydrates_description[index] = v;
        }
        else if (k == "bridge")
        {
            Opening_Values.sweets_fats_description[index]= v;
        }
        else if (k == "OrchardSetup")
        {
            Opening_Values.vegetable_fruit_description[index] =v;
        }

    }




    public void set_name(int index,string v )
    {
        Debug.Log("Level" + index);
        string k = SceneManager.GetActiveScene().name;

        if (k == "market")
        {
            Opening_Values.protein_dairy_name[index] =v;
        }
        else if (k == "magic glade")
        {
            Opening_Values.carbohydrates_name[index] = v;
        }
        else if (k == "bridge")
        {
            Opening_Values.sweets_fats_name[index]= v;
        }
        else if (k == "OrchardSetup")
        {
            Opening_Values.vegetable_fruit_name[index] =v;
        }

    }
    public void NextPage()
    {
        GameObject i;
        
        string n="";
        int j = 1;
      
        i = GameObject.Find("h1");
        if (i.transform.GetChild(0).childCount > 0)
        {
            Debug.Log("sdfsd");
            n = i.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite.name;
            set_name(0, n);
            set_description(0,n);
        }
        else { j = 0; }

        i = GameObject.Find("h2");
        if (i.transform.GetChild(0).childCount > 0)
        {

            Debug.Log("sdfsd");
            n = i.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite.name;
            set_name(1,n);
            set_description(1, n);
        }
        else { j = 0; }

        i = GameObject.Find("h3");
        if (i.transform.GetChild(0).childCount > 0)
        {
            Debug.Log("sdfsd");
            n = i.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite.name;
            set_name(2, n);
            set_description(2, n);
        }
        else { j = 0; }

        i = GameObject.Find("h4");
        if (i.transform.GetChild(0).childCount > 0)
        {
            Debug.Log("sdfsd");
            n = i.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite.name;
            set_name(3, n);
            set_description(3, n);
        }
        else { j = 0; }


        i = GameObject.Find("h5");
        if (i.transform.GetChild(0).childCount > 0)
        {
            Debug.Log("sdfsd");
            n = i.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite.name;
            set_name(4, n);
            set_description(4, n);
        }
        else { j = 0; }

        Debug.Log("j" + j);
        if (j == 1)
        {

            string k = SceneManager.GetActiveScene().name;

            Debug.Log("k" + k);
            if (k == "market")
            {
           //   SceneManager.LoadScene("marketplace");

               SceneManager.LoadScene("magic glade");
            }
            if (k == "magic glade")
            {
              // SceneManager.LoadScene("magic_glade");
            SceneManager.LoadScene("OrchardSetup");
            }
            if (k == "OrchardSetup")
            {
            SceneManager.LoadScene("bridge");

           //     SceneManager.LoadScene("orchard");
            }
            if (k == "bridge")
            {
                SceneManager.LoadScene("Intro_CutScene");
            }
        }

        try
        {

        }
        catch(System.Exception e)
        {

        }

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
