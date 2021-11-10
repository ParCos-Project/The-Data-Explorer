using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add_Button_Check : MonoBehaviour
{
    public Button AddButton;
    public Button RemoveButton;
    public Button SelectionButton;
    public Button CloseMenu;

    void Start()
    {
        //define add/remove button and set it to inactive as default
        Button AddButton = gameObject.GetComponent<Button>();
        AddButton.GetComponent<Button>().interactable = false;
        
        //check selection button
        Button CheckSelection = SelectionButton.GetComponent<Button>();
		CheckSelection.onClick.AddListener(EnableSelection);

       //check corrosponding remove button
        Button CheckRemove = RemoveButton.GetComponent<Button>();
		CheckRemove.onClick.AddListener(EnableSelection);

        //chekc close button
        Button CheckClose = CloseMenu.GetComponent<Button>();
		CheckClose.onClick.AddListener(DisableSelection);
    }

   public void EnableSelection ()
   {
       AddButton.GetComponent<Button>().interactable = true;
   }

   public void DisableSelection ()
   {
       AddButton.GetComponent<Button>().interactable = false;
   }
}
