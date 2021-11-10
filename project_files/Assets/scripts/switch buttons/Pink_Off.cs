using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pink_Off : MonoBehaviour
{
    public Button OffButton; 

    [SerializeField]
    private Color onColor;
    [SerializeField]
    private Color offColor;

    Image ButtonImage;

    void Start()
    {
        Button OffPink = OffButton.GetComponent<Button>();
        OffPink.onClick.AddListener(PinkButtonOff);
    }

    void PinkButtonOff(){
        Pink_On.PinkSwitch = false;

	}

    void Update()
    {
        if(Pink_On.PinkSwitch == false)
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
