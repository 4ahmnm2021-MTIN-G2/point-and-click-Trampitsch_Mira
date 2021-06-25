using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geheilt : MonoBehaviour
{
    public GameObject textFeld;
    public GameObject hexeGeheilt;

    public void OnMouseDown()
    {

        textFeld.SetActive(true);
        hexeGeheilt.SetActive(true);

    }

  



}
