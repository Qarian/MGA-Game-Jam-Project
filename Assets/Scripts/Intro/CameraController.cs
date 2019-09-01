using UnityEngine;

public class CameraController : MonoBehaviour
{
	[SerializeField]
	float cameraOffset = default;
	[SerializeField]
	float playerMaxDistance = default;

	[SerializeField]
	Transform player = default;

	private void Update()
	{
		float distance = player.position.x - transform.position.x;
		if (distance < cameraOffset)
		{
			transform.Translate(distance - cameraOffset, 0, 0);
		}

		if (distance > playerMaxDistance)
		{
			player.Translate(playerMaxDistance - distance, 0, 0);
		}
	}
}
