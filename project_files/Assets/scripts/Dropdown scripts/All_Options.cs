using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class All_Options : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    //create public dropdown menus and sprites so they can be accessed in the Unity editor. 
    public TMPro.TMP_Dropdown ddLocation;
    public Sprite ShinyStar;
    public Sprite BasicStar;
    public Sprite ShinyStar_Hover;
    public Sprite BasicStar_Hover;

    //create an int called DropDown_Location, make sure it is public so that it can be access globally. We will use this later.
    public int DropDown_Location;


    //create a listener in the Start so that we can know when an item in the dropdown menu is selected. 
    private void Start()
    {
        ddLocation.onValueChanged.AddListener(delegate
        {
            ddLocationChange(ddLocation);
        });
    }
      

    //log when the mouse is over the data star object.
    //and change the sprite if the mouse is on the object and the item of of the dropdown menu.
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(DropDown_Location == 0)
        {
            this.gameObject.GetComponent<Image>().sprite = BasicStar_Hover;
            Debug.Log("circle Hover");
        }

        if(DropDown_Location != 0)
        {
            this.gameObject.GetComponent<Image>().sprite = ShinyStar_Hover;
            Debug.Log("diamond Hover");
        }
     
    }

    //log when the mouse leaves the data star object.
    //and change the sprite if the mouse is off the object and the item of of the dropdown menu.
    public void OnPointerExit(PointerEventData eventData)
    {
        if(DropDown_Location == 0)
        {
            this.gameObject.GetComponent<Image>().sprite = BasicStar;
            Debug.Log("circle");
        }

        if(DropDown_Location != 0)
        {
            this.gameObject.GetComponent<Image>().sprite = ShinyStar;
            Debug.Log("diamond");
        }
        
     
    }

    //create a method that can take the listener we put on the dropdown menu and connect it with the "data star" sprite. 
    public void ddLocationChange(TMPro.TMP_Dropdown sender)
    {
        //get the value of the sender and store it in the DropDown_Location int.
        DropDown_Location = sender.value; 
         
         //change the sprite if the desired item in the dropdown is selected.
        if(DropDown_Location == 0)
        {
            this.gameObject.GetComponent<Image>().sprite = BasicStar;
            Debug.Log("circle");
        }

        //change the sprite based on the int of the dropdown menu if it is not the desired item in the dropdown menu.
        else if(DropDown_Location != 0)

        {
            this.gameObject.GetComponent<Image>().sprite = ShinyStar;
            Debug.Log("diamond");
        }
    }
   
}
