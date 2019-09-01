using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpike : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log(collision);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log(collision);
		if (collision.tag == "Player")
		{
			PlayerMovement player = collision.GetComponent<PlayerMovement>();
			player.Death();
		}
	}
}
