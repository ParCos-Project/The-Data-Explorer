using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pink_On : MonoBehaviour
{
    public Button OnButton;
    public static bool PinkSwitch;

    [SerializeField]
    private Color onColor;
    [SerializeField]
    private Color offColor;

    Image ButtonImage;

    void Start()
    {
        Button OnPink = OnButton.GetComponent<Button>();
		OnPink.onClick.AddListener(PinkButtonOn);
    }

    void PinkButtonOn(){
        PinkSwitch = true;
	}

    void Update()
    {
        if(PinkSwitch == true)
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

