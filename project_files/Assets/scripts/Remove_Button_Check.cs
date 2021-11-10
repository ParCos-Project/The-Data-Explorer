using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remove_Button_Check : MonoBehaviour
{
    public Button RemoveButton;
    public Button SelectionButton;
    public Button CloseMenu;

    void Start()
    {
        //define add/remove button and set it to inactive as default
        Button RemoveButton = gameObject.GetComponent<Button>();
        RemoveButton.GetComponent<Button>().interactable = false;
        
        //check selection button
        Button CheckSelection = SelectionButton.GetComponent<Button>();
		CheckSelection.onClick.AddListener(EnableSelection);

        //check close button
        Button CheckClose = CloseMenu.GetComponent<Button>();
		CheckClose.onClick.AddListener(DisableSelection);
    }

   public void EnableSelection ()
   {
      RemoveButton.GetComponent<Button>().interactable = true;
   }

   public void DisableSelection ()
   {
       RemoveButton.GetComponent<Button>().interactable = false;
   }
}
