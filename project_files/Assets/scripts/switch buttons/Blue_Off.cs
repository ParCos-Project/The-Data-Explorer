using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blue_Off : MonoBehaviour
{
    public Button OffButton; 

    [SerializeField]
    private Color onColor;
    [SerializeField]
    private Color offColor;

    Image ButtonImage;

    void Start()
    {
        Button OffBlue = OffButton.GetComponent<Button>();
        OffBlue.onClick.AddListener(BlueButtonOff);
    }

    void BlueButtonOff(){
        Blue_On.BlueSwitch = false;

	}

    void Update()
    {
        if(Blue_On.BlueSwitch == false)
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
