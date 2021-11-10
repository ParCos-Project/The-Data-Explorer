using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blue_Star : MonoBehaviour
{
    [SerializeField]
    private Color onColor;
    [SerializeField]
    private Color offColor;

    Image StarImage;

    void BlueThemeOn()
    {
        if(Blue_On.BlueSwitch == true)
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
        BlueThemeOn();
    }
}
