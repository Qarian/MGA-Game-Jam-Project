using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupMan : MonoBehaviour
{
    public Skins skins;
    
    public GameObject head;
    public GameObject spodnie;
    public GameObject buty;
    
    // Start is called before the first frame update
    void Start()
    {
        head.GetComponent<MeshRenderer>().material = skins.head[skins.headID];
        spodnie.GetComponent<MeshRenderer>().material = skins.body[skins.bodyID];
        buty.GetComponent<MeshRenderer>().material = skins.legs[skins.legsID];
    }
    
}
