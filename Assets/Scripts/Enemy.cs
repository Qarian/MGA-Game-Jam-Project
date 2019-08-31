using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	enum Direction { Left, Right};

	[SerializeField]
	float speed = 5;
	[SerializeField]
	Direction movementDir = Direction.Right;

	[SerializeField]
	Transform[] checkTransforms = new Transform[2];

	Transform currentChecktransform;

	[SerializeField]
	Rigidbody2D rb = default;

	void Start()
	{
		currentChecktransform = checkTransforms[(int)movementDir];
		if (movementDir == Direction.Right)
			rb.velocity = new Vector2(speed, rb.velocity.y);
		else if (movementDir == Direction.Left)
			rb.velocity = new Vector2(-speed, rb.velocity.y);
	}

	void FixedUpdate()
    {
		if (Physics2D.OverlapCircle(currentChecktransform.position, currentChecktransform.localScale.x, LayerMask.GetMask("Enviroment")) != null)
			ChangeDirection();
	}

	void ChangeDirection()
	{
		if (movementDir == Direction.Right)
		{
			movementDir = Direction.Left;
			rb.velocity = new Vector2(-speed, rb.velocity.y);
			currentChecktransform = checkTransforms[(int)movementDir];
		}
		else if (movementDir == Direction.Left)
		{
			movementDir = Direction.Right;
			rb.velocity = new Vector2(speed, rb.velocity.y);
			currentChecktransform = checkTransforms[(int)movementDir];
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
			Destroy(transform.parent.gameObject);
	}
}
