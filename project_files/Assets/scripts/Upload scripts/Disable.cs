using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    public GameObject DisableEnable;

    public void DisableObject ()
    {
        DisableEnable.SetActive(false);
    }

    public void EnabledObject ()
    {
        DisableEnable.SetActive(true);
    }
}
