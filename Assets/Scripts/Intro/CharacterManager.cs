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
    
    void Start()
    {
        head.GetComponent<MeshRenderer>().material = skins.head[skins.headID];
        legs.GetComponent<MeshRenderer>().material = skins.body[skins.bodyID];
        body.GetComponent<MeshRenderer>().material = skins.legs[skins.legsID];
    }
    
    public void ChangeHead(bool isRight)
    {
        if (isRight)
        {
            if (skins.headID < skins.head.Count - 1)
            {
                skins.headID++;
                head.GetComponent<MeshRenderer>().material = skins.head[skins.headID];
                if (skins.headID == skins.head.Count - 1) skins.headID = 0;
            }
        }
        else
        {
            if (skins.headID > 0)
            {
                skins.headID--;
                head.GetComponent<MeshRenderer>().material = skins.head[skins.headID];
                if (skins.headID == 0) skins.headID =  skins.head.Count - 1;
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
                body.GetComponent<MeshRenderer>().material = skins.body[skins.bodyID];
                if (skins.bodyID == skins.body.Count - 1) skins.bodyID = 0;
            }
        }
        else
        {
            if (skins.bodyID > 0)
            {
                skins.bodyID--;
                body.GetComponent<MeshRenderer>().material = skins.body[skins.bodyID];
                if (skins.bodyID == 0) skins.bodyID = skins.body.Count - 1;
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
                legs.GetComponent<MeshRenderer>().material = skins.legs[skins.legsID];
                if (skins.legsID == skins.legs.Count - 1) skins.legsID = 0;
            }
        }
        else
        {
            if (skins.legsID > 0)
            {
                skins.legsID--;
                legs.GetComponent<MeshRenderer>().material = skins.legs[skins.legsID];
                if (skins.legsID == skins.legs.Count - 1) skins.legsID = 0;
            }
        }
        Debug.Log("LegsID: " + skins.legsID);
    }

    public void ChangeSkinColor(bool isRight)
    {
        
        
        
    }
    
    
}

