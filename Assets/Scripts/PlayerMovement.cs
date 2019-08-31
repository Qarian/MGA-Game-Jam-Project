using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
	[SerializeField]
	Transform groundCheckTransform = default;

	[Space]
	public float maxSpeed;
	public float acceleration;
	public float jumpForce;

	[Space]
	public KeyCode left = KeyCode.A;
	public KeyCode right = KeyCode.D;
	public KeyCode jump = KeyCode.Space;

	Rigidbody2D rb;

	float currentSpeed;
	bool canJump = false;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (Input.GetKeyDown(left))
			ChangeSpeed(acceleration * Time.deltaTime * -1f);
		if (Input.GetKeyDown(right))
			ChangeSpeed(acceleration * Time.deltaTime);

		if (Input.GetKeyDown(jump) && canJump)
			Jump();

		canJump = Physics2D.OverlapCircle(groundCheckTransform.position, groundCheckTransform.localScale.y, LayerMask.GetMask("Enviroment")) != null;
	}

	void ChangeSpeed(float amount)
	{
		currentSpeed += amount;
		currentSpeed = Mathf.Clamp(currentSpeed, -maxSpeed, maxSpeed);
	}

	void Jump()
	{
		rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

		canJump = false;
	}

	void FixedUpdate()
	{
		if (currentSpeed != 0)
			rb.velocity = new Vector2(currentSpeed, rb.velocity.y);
		currentSpeed = 0;
	}
}
