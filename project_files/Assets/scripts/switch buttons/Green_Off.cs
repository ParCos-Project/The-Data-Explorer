using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Green_Off : MonoBehaviour
{
    public Button OffButton; 

    [SerializeField]
    private Color onColor;
    [SerializeField]
    private Color offColor;

    Image ButtonImage;

    void Start()
    {
        Button OffGreen = OffButton.GetComponent<Button>();
        OffGreen.onClick.AddListener(GreenButtonOff);
    }

    void GreenButtonOff(){
        Green_On.GreenSwitch = false;

	}

    void Update()
    {
        if(Green_On.GreenSwitch == false)
        {
            ButtonImage = GetComponent<Image>();
            ButtonImage.color = onColor;
        }

        else
        {
            ButtonImage = GetComponent<Image>();
            ButtonImage.color = offColor;
        }

    }
}
