using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Green_On : MonoBehaviour
{
    public Button OnButton;
    public static bool GreenSwitch;

    [SerializeField]
    private Color onColor;
    [SerializeField]
    private Color offColor;

    Image ButtonImage;

    void Start()
    {
        Button OnGreen = OnButton.GetComponent<Button>();
		OnGreen.onClick.AddListener(GreenButtonOn);
    }

    void GreenButtonOn(){
        GreenSwitch = true;
	}

    void Update()
    {
        if(GreenSwitch == true)
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