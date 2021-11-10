using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pink_Star : MonoBehaviour
{
    [SerializeField]
    private Color onColor;
    [SerializeField]
    private Color offColor;

    Image StarImage;

    void PinkThemeOn()
    {
        if(Pink_On.PinkSwitch == true)
        {
            StarImage = GetComponent<Image>();
            StarImage.color = onColor;
        }

        else
        {
            StarImage = GetComponent<Image>();
            StarImage.color = offColor;
        }
    }

    void Update()
    {
        PinkThemeOn();
    }
}
