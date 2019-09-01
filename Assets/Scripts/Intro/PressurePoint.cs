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

	private void Start()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();

		normalSprite = spriteRenderer.sprite;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		spriteRenderer.sprite = clickedSprite;
		activatedButton.Invoke();
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (stayClicked)
			return;

		spriteRenderer.sprite = normalSprite;
		deactivatedButton.Invoke();
	}
}
