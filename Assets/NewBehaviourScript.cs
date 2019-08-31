using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
	[SerializeField]
	Vector3 vel;

	AudioSource source;
	public AudioSource objecta;

    // Start is called before the first frame update
    void Start()
    {
		source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		transform.Translate(vel * Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			source.loop = false;
			source.Play();
		}
    }
}
