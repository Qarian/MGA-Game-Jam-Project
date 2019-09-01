using UnityEngine;

public class EnemySpike : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			PlayerMovement player = collision.GetComponent<PlayerMovement>();
			player.Death();
		}
	}
}
