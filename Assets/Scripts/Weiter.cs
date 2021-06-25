using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weiter : MonoBehaviour
{
    public GameObject blase1;
    public GameObject blase2;
    public GameObject blase3;
    public GameObject blase4;

    public int counter = 0;


    public void OnMouseDown()
    {
        blase1.SetActive(false);
        counter=1;

        if (counter == 1)

        {
            
            blase2.SetActive(false);
            counter =2;
            Debug.Log(" if funktioniert");
        }

        if (counter == 2)

        {
            blase3.SetActive(false);
            counter =3;
        }


    }
   
}
