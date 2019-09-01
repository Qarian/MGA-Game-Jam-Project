using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void OnButtonClicked()
    {
        
        this.GetComponent<AudioSource>().Play();
        
    }
}
