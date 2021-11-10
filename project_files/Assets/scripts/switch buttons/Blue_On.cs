using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blue_On : MonoBehaviour
{
    public Button OnButton;
    public static bool BlueSwitch;

    [SerializeField]
    private Color onColor;
    [SerializeField]
    private Color offColor;

    Image ButtonImage;

    void Start()
    {
        Button OnBlue = OnButton.GetComponent<Button>();
		OnBlue.onClick.AddListener(BlueButtonOn);
    }

    void BlueButtonOn(){
        BlueSwitch = true;
	}

    void Update()
    {
        if(BlueSwitch == true)
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
