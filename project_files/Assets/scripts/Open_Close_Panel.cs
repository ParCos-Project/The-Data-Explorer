using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Close_Panel : MonoBehaviour
{
    public GameObject Panel;
    //public GameObject UserUpload;

    public void OpenPanel ()
    {
        if(Panel !=null)
        {
            Panel.SetActive(true);
        }
    }

    public void ClosePanel ()
    {

            Panel.SetActive(false);
    }

    // public void UserUploadOn ()

    // {
    //     if(UserUpload !=null)
    //     {
    //         UserUpload.SetActive(true);
    //     }
    // }
}
