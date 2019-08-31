using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class statsNumberLeftController : MonoBehaviour
{

    public GameObject buttonStart;


    private void Update()
    {
       int leftPoints = Int32.Parse(this.GetComponent<TextMeshProUGUI>().text);

       if (leftPoints != 0)
       {
           buttonStart.SetActive(false);
       }
       else
       {
           buttonStart.SetActive(true);
       }
    }
}
