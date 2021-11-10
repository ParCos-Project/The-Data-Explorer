using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quite_Game : MonoBehaviour
{
    public void Quite()
    {
            Application.Quit();
            Debug.Log("game over");
    }
}
