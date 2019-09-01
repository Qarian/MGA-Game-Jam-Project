using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioController : MonoBehaviour
{
    void Start()
    {
		DontDestroyOnLoad(gameObject);
    }

	private void Update()
	{
		if (SceneManager.GetActiveScene().buildIndex == 2)
			if (Input.GetKeyDown(KeyCode.R))
				SceneManager.LoadScene(2);
	}
}
