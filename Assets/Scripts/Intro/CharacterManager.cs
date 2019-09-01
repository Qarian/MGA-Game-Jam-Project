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
            if (skins.headID <= skins.head.Count - 1)
            {
                skins.headID++;
                if (skins.headID == skins.head.Count) skins.headID = 0;
                head.GetComponent<MeshRenderer>().material = skins.head[skins.headID];
                
            }
        }
        else
        {
            if (skins.headID >= 0)
            {
                skins.headID--;
                if (skins.headID == -1) skins.headID =  skins.head.Count - 1;
                head.GetComponent<MeshRenderer>().material = skins.head[skins.headID];
                
            }
        }
        Debug.Log("HeadID: " + skins.headID);
    }
    
    public void ChangeBody(bool isRight)
    {
        if (isRight)
        {
            if (skins.bodyID <= skins.body.Count - 1)
            {
                skins.bodyID++;
                if (skins.bodyID == skins.body.Count ) skins.bodyID = 0;
                body.GetComponent<MeshRenderer>().material = skins.body[skins.bodyID];
                
            }
        }
        else
        {
            if (skins.bodyID >= 0)
            {
                skins.bodyID--;
                if (skins.bodyID == -1) skins.bodyID = skins.body.Count - 1;
                body.GetComponent<MeshRenderer>().material = skins.body[skins.bodyID];
                
            }
        }
        Debug.Log("BodyID: " + skins.bodyID);
    }
    
    public void ChangeLegs(bool isRight)
    {
        if (isRight)
        {
            if (skins.legsID <= skins.legs.Count - 1)
            {
                skins.legsID++;
                if (skins.legsID == skins.legs.Count) skins.legsID = 0;
                legs.GetComponent<MeshRenderer>().material = skins.legs[skins.legsID];
              
            }
        }
        else
        {
            if (skins.legsID >= 0)
            {
                skins.legsID--;
                if (skins.legsID == -1) skins.legsID = skins.legs.Count - 1;
                legs.GetComponent<MeshRenderer>().material = skins.legs[skins.legsID];
            }
        }
        Debug.Log("LegsID: " + skins.legsID);
    }
    
    
    
}

