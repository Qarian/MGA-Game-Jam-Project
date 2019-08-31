using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsButtonResponse : MonoBehaviour
{
    private int statisticScore;
    private int int_pointsLeft;
    public GameObject pointsLeft;

    public GameObject buttonPlus;
    public GameObject buttonMinus;
    
    // Start is called before the first frame update
    void Start()
    {
        statisticScore =  Int32.Parse(this.GetComponent<TextMeshProUGUI>().text);
        int_pointsLeft = Int32.Parse(pointsLeft.GetComponent<TextMeshProUGUI>().text); 
    }

    public void ChangeStat(bool isPlus)
    {
        int_pointsLeft = Int32.Parse(pointsLeft.GetComponent<TextMeshProUGUI>().text); 
        if (isPlus)
        {
            if (statisticScore < 9)
            {
                buttonMinus.SetActive(true);
                statisticScore++;
               
                
                if (statisticScore == 9)
                {
                    buttonPlus.SetActive(false);
                }

            }
            int_pointsLeft--;
            
        }
        else
        {
            int_pointsLeft = Int32.Parse(pointsLeft.GetComponent<TextMeshProUGUI>().text); 
            buttonPlus.SetActive(true);
            if (statisticScore > 0)
            {
                statisticScore--;
               
            }

            if (statisticScore == 0)
            {
                buttonMinus.SetActive(false);
            }
            int_pointsLeft++;  
        }
        this.GetComponent<TextMeshProUGUI>().text = statisticScore.ToString();
        pointsLeft.GetComponent<TextMeshProUGUI>().text = int_pointsLeft.ToString();

    }
}
