using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField]
	Transform groundCheckTransform = default;
	[SerializeField]
	GameObject gameOverCanvas = default;
	[SerializeField]
	AudioSource jumpSound = default;

	[Space]
	public float maxSpeed;
	public float jumpForce;
	[SerializeField]
	float deathJumpSpeed = default;

	[Space]
	public KeyCode left = KeyCode.A;
	public KeyCode right = KeyCode.D;
	public KeyCode jump = KeyCode.Space;

	Rigidbody2D rb;
	Animator animator;
	AudioSource movingSound;

	float currentSpeed = 0;
	bool canJump = false;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		movingSound = GetComponent<AudioSource>();
		movingSound.volume = 0;
	}

	void Update()
	{
		currentSpeed = Input.GetAxis("Horizontal") * maxSpeed;
		movingSound.volume = Mathf.Abs(Input.GetAxis("Horizontal")) * 0.5f;

		if (Input.GetKeyDown(jump) && canJump)
			animator.SetTrigger("Jump");

		canJump = Physics2D.OverlapCircle(groundCheckTransform.position, groundCheckTransform.localScale.y, LayerMask.GetMask("Enviroment")) != null;
	}

	public void Jump()
	{
		rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);

		canJump = false;
	}

	void FixedUpdate()
	{
		if (currentSpeed != 0)
			rb.velocity = new Vector2(currentSpeed, rb.velocity.y);
	}

	public void Death()
	{
		Collider2D[] colliders = new Collider2D[1];
		rb.GetAttachedColliders(colliders);
		colliders[0].enabled = false;
		rb.velocity = new Vector2(0, deathJumpSpeed);
		Instantiate(gameOverCanvas);
		Destroy(this);
	}

	public void JumpSound()
	{
		jumpSound.Play();
	}
}
