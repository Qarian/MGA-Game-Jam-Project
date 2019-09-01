using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
	[SerializeField]
	List<GameObject> clouds = default;
	[SerializeField]
	float cloudsStartXPos = 14f;

	[SerializeField]
	Vector2 minMaxCloudsHeight = new Vector2(1f, 3f);
	[SerializeField]
	Vector2 minMaxCloudSpeed = new Vector2(4f, 8f);
	[SerializeField]
	Vector2 minMaxCloudGenerateTime = new Vector2(1f, 4f);

	float nextGenerateTime = 0;

	private void Update()
	{
		if (nextGenerateTime <= Time.time)
		{
			GameObject go = Instantiate(clouds[Random.Range(0, clouds.Count)], new Vector3(cloudsStartXPos, Random.Range(minMaxCloudsHeight.x, minMaxCloudsHeight.y), 0f), Quaternion.identity);
			go.GetComponent<Cloud>().speed = Random.Range(minMaxCloudSpeed.x, minMaxCloudSpeed.y);
			nextGenerateTime = Time.time + Random.Range(minMaxCloudGenerateTime.x, minMaxCloudGenerateTime.y);
		}
	}

}
