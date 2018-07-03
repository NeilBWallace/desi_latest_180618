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
        Debug.Log("Level" + k);
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
        else if (k == "Orchard")
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
        else if (k == "Orchard")
        {
            Opening_Values.vegetable_fruit_name[index] =v;
        }

    }
    public void NextPage()
    {
        GameObject i;
        i = GameObject.Find("Slots - Inventory(Clone)");
   

        if (i.transform.GetChild(0).GetChild(0).childCount > 0)
        {
           // Image j = i.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>();
            set_name(0, i.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>().sprite.name);
            item = i.transform.GetChild(0).GetChild(0).GetComponent<ItemOnObject>(); 
            set_description(0, item.itemname);
        }
        //     Debug.Log ("sfsdf" + j.sprite.name);

        if (i.transform.GetChild(1).GetChild(0).childCount > 0)
        {
            set_name(1, i.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Image>().sprite.name);
            item = i.transform.GetChild(1).GetChild(0).GetComponent<ItemOnObject>();
            set_description(1, item.itemname);


        }
        if (i.transform.GetChild(2).GetChild(0).childCount > 0)
        {        
            set_name(2, i.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Image>().sprite.name);
            item = i.transform.GetChild(2).GetChild(0).GetComponent<ItemOnObject>();
            set_description(2, item.itemname);
        }

        if (i.transform.GetChild(3).GetChild(0).childCount > 0)
        {
            set_name(3, i.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Image>().sprite.name);

            item = i.transform.GetChild(3).GetChild(0).GetComponent<ItemOnObject>();
            set_description(3, item.itemname);
        }

        if (i.transform.GetChild(4).GetChild(0).childCount > 0)
        {
            set_name(4, i.transform.GetChild(4).GetChild(0).GetChild(0).GetComponent<Image>().sprite.name);
            item = i.transform.GetChild(4).GetChild(0).GetComponent<ItemOnObject>();
            set_description(4, item.itemname);
        }
        
     


      string  k = SceneManager.GetActiveScene().name;

        Debug.Log("k" + k);
        if (k == "market")
        {
            SceneManager.LoadScene("marketplace");
        }
        if (k == "magic glade")
        {
            SceneManager.LoadScene("magic_glade");
        }
        if (k == "Orchard")
        {
            SceneManager.LoadScene("orchard");
        }
        if (k == "bridge")
        {
            SceneManager.LoadScene("thebridge");
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
