using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
	public float speed = -2;

	private void Update()
	{
		transform.Translate(speed * Time.deltaTime, 0f, 0f);
	}
}
