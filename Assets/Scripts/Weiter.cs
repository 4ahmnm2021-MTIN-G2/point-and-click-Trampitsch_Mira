using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weiter : MonoBehaviour
{
    public GameObject blase1;
    public GameObject blase2;
    public GameObject blase3;
    public GameObject blase4;

    public int counter;


    public void ClickWeiter()
    {
        blase1.SetActive(false);
        counter = +1;

        if (counter ==1)

        {
            blase2.SetActive(false);
            counter = +1;
        }
     
    }
   
}
