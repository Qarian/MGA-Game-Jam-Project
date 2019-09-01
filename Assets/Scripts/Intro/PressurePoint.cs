using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressurePoint : MonoBehaviour
{
	[SerializeField]
	Sprite clickedSprite = default;
	Sprite normalSprite;

	[SerializeField]
	bool stayClicked = false;
	public UnityEvent activatedButton;
	public UnityEvent deactivatedButton;

	SpriteRenderer spriteRenderer;
	AudioSource audioSource;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
		spriteRenderer = GetComponent<SpriteRenderer>();

		normalSprite = spriteRenderer.sprite;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		spriteRenderer.sprite = clickedSprite;
		activatedButton.Invoke();

		audioSource.pitch = 0.5f;
		audioSource.Play();
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (stayClicked)
			return;

		spriteRenderer.sprite = normalSprite;
		deactivatedButton.Invoke();

		audioSource.pitch = 1.5f;
		audioSource.Play();
	}
}
