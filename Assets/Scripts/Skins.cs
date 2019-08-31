using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Skins", menuName = "Skins", order = 1)]
public class Skins : ScriptableObject
{
    public List<Sprite> head;
    public List<Sprite> body;
    public List<Sprite> legs;

    public int headID = 0;
    public int bodyID = 0;
    public int legsID = 0;
}
