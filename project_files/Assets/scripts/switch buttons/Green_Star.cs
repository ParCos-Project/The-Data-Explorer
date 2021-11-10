using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Green_Star : MonoBehaviour
{
    [SerializeField]
    private Color onColor;
    [SerializeField]
    private Color offColor;

    Image StarImage;

    void GreenThemeOn()
    {
        if(Green_On.GreenSwitch == true)
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
        GreenThemeOn();
    }
}

