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
    
    // Start is called before the first frame update
    void Start()
    {
        statisticScore =  Int32.Parse(this.GetComponent<TextMeshProUGUI>().text);
        int_pointsLeft = Int32.Parse(pointsLeft.GetComponent<TextMeshProUGUI>().text); 
    }

    public void ChangeStat(bool isPlus)
    {
        if (isPlus)
        {
            statisticScore++;
            int_pointsLeft--;
        }
        else
        {
            statisticScore--;
            int_pointsLeft++;
        }
        this.GetComponent<TextMeshProUGUI>().text = statisticScore.ToString();
        pointsLeft.GetComponent<TextMeshProUGUI>().text = int_pointsLeft.ToString();

    }
}
