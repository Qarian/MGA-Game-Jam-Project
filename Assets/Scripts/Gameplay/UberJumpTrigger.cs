using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UberJumpTrigger : MonoBehaviour
{
	[SerializeField]
	float newJumpForce = 200f;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			PlayerMovement player = collision.GetComponent<PlayerMovement>();
			player.jumpForce = newJumpForce;
		}
	}
}
