using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
	public static AudioController singleton;

	void Start()
    {
	    if (singleton != null)
	    {
		    Destroy(gameObject);
		    return;
	    }
		DontDestroyOnLoad(gameObject);
		singleton = this;
    }

	private void Update()
	{
		if (SceneManager.GetActiveScene().buildIndex == 2)
			if (Input.GetKeyDown(KeyCode.R))
				SceneManager.LoadScene(2);
		
		if (Input.GetKeyDown(KeyCode.P))
			SceneManager.LoadScene(0);
	}
}
