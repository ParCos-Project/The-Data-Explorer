using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_Star_Selection : MonoBehaviour
{
     public GameObject Button1;
     public GameObject Button2;
     public GameObject Button3;
     
     public static bool DataSet1;
     public static bool DataSet2;
     public static bool DataSet3;
     public static bool DataSet4;
     public static bool DataSet5;
     public static bool DataSet6;

///add/remove first data set
    public void AddDataStar1 ()
    {
        if(Button1 !=null)
        {
            Button1.SetActive(true);
            DataSet1 = true;
        }

        if(Button2 !=null)
        {
            Button2.SetActive(true);
            DataSet1 = true;
        }

        if(Button3 !=null)
        {
            Button3.SetActive(true);
            DataSet1 = true;
        }
    }

    public void RemoveDataStar1 ()
    {

            Button1.SetActive(false);
            DataSet1 = false;

            Button2.SetActive(false);
            DataSet1 = false;

            Button3.SetActive(false);
            DataSet1 = false;
    }

//add/remove second data set
    public void AddDataStar2 ()
    {
        if(Button1 !=null)
        {
            Button1.SetActive(true);
            DataSet2 = true;
        }

        if(Button2 !=null)
        {
            Button2.SetActive(true);
            DataSet2 = true;
        }

        if(Button3 !=null)
        {
            Button3.SetActive(true);
            DataSet2 = true;
        }
    }

    public void RemoveDataStar2 ()
    {

            Button1.SetActive(false);
            DataSet2 = false;

            Button2.SetActive(false);
            DataSet2 = false;

            Button3.SetActive(false);
            DataSet2 = false;
    }

//add/remove third data set
public void AddDataStar3 ()
    {
        if(Button1 !=null)
        {
            Button1.SetActive(true);
            DataSet3 = true;
        }

        if(Button2 !=null)
        {
            Button2.SetActive(true);
            DataSet3 = true;
        }

        if(Button3 !=null)
        {
            Button3.SetActive(true);
            DataSet3 = true;
        }
    }

    public void RemoveDataStar3 ()
    {

            Button1.SetActive(false);
            DataSet3 = false;

            Button2.SetActive(false);
            DataSet3 = false;

            Button3.SetActive(false);
            DataSet3 = false;
    }

//add/remove 4th data set
public void AddDataStar4 ()
    {
        if(Button1 !=null)
        {
            Button1.SetActive(true);
            DataSet4 = true;
        }

        if(Button2 !=null)
        {
            Button2.SetActive(true);
            DataSet4 = true;
        }

        if(Button3 !=null)
        {
            Button3.SetActive(true);
            DataSet4 = true;
        }
    }

    public void RemoveDataStar4 ()
    {

            Button1.SetActive(false);
            DataSet4 = false;

            Button2.SetActive(false);
            DataSet4 = false;

            Button3.SetActive(false);
            DataSet4 = false;
    }

//add/remove 5th data set
public void AddDataStar5 ()
    {
        if(Button1 !=null)
        {
            Button1.SetActive(true);
            DataSet5 = true;
        }

        if(Button2 !=null)
        {
            Button2.SetActive(true);
            DataSet5 = true;
        }

        if(Button3 !=null)
        {
            Button3.SetActive(true);
            DataSet5 = true;
        }
    }

    public void RemoveDataStar5 ()
    {

            Button1.SetActive(false);
            DataSet5 = false;

            Button2.SetActive(false);
            DataSet5 = false;

            Button3.SetActive(false);
            DataSet5 = false;
    }

//add remove 6th data set
public void AddDataStar6 ()
    {
        if(Button1 !=null)
        {
            Button1.SetActive(true);
            DataSet6 = true;
        }

        if(Button2 !=null)
        {
            Button2.SetActive(true);
            DataSet6 = true;
        }

        if(Button3 !=null)
        {
            Button3.SetActive(true);
            DataSet6 = true;
        }
    }

    public void RemoveDataStar6 ()
    {

            Button1.SetActive(false);
            DataSet6 = false;

            Button2.SetActive(false);
            DataSet6 = false;

            Button3.SetActive(false);
            DataSet6 = false;
    }
}
