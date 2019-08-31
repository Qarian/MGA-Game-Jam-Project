using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;

public class CharacterManager : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject legs;
    public Skins skins;
    
    public void ChangeHead(bool isRight)
    {
        if (isRight)
        {
            if (skins.headID < skins.head.Count - 1)
            {
                skins.headID++;
                head.GetComponent<RawImage>().texture = skins.head[skins.headID].texture;
            }
        }
        else
        {
            if (skins.headID > 0)
            {
                skins.headID--;
                head.GetComponent<RawImage>().texture = skins.head[skins.headID].texture;
            }
        }
        Debug.Log("HeadID: " + skins.headID);
    }
    
    public void ChangeBody(bool isRight)
    {
        if (isRight)
        {
            if (skins.bodyID < skins.body.Count - 1)
            {
                skins.bodyID++;
                body.GetComponent<RawImage>().texture = skins.body[skins.bodyID].texture;
            }
        }
        else
        {
            if (skins.bodyID > 0)
            {
                skins.bodyID--;
                body.GetComponent<RawImage>().texture = skins.body[skins.bodyID].texture;
            }
        }
        Debug.Log("BodyID: " + skins.bodyID);
    }
    
    public void ChangeLegs(bool isRight)
    {
        if (isRight)
        {
            if (skins.legsID < skins.legs.Count - 1)
            {
                skins.legsID++;
                legs.GetComponent<RawImage>().texture = skins.legs[skins.legsID].texture;
            }
        }
        else
        {
            if (skins.legsID > 0)
            {
                skins.legsID--;
                legs.GetComponent<RawImage>().texture = skins.legs[skins.legsID].texture;
            }
        }
        Debug.Log("LegsID: " + skins.legsID);
    }

    public void ChangeSkinColor(bool isRight)
    {
        
        
        
    }
    
    
}

