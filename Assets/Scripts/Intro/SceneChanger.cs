using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
			Restart();
	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

	public void LoadNextScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadPreviousScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
}