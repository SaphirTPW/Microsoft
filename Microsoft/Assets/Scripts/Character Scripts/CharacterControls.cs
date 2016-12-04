using UnityEngine;
using System.Collections;

public class CharacterControls : MonoBehaviour {

	private float moveSpeed = 3.0f;
	private float moveVelocity = 2.0f;
	private float jumpHeight = 6.0f;
	private Rigidbody2D rb;
	private isGrounded ground;
	private BoxCollider2D collider;
	private bool down = false;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		ground = GetComponent<isGrounded> ();
		collider = GetComponent<BoxCollider2D> ();

	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.D))
			MoveRight ();

		if (Input.GetKey (KeyCode.A))
			MoveLeft ();
		if (Input.GetKeyDown (KeyCode.S))
			GetDownP ();

		if (Input.GetKeyDown (KeyCode.Space) && ground.Grounded())
			Jump ();
	}

	void FixedUpdate ()
	{
		
	}

	void MoveRight()
	{
		rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);
		moveVelocity = moveSpeed;
	}

	void MoveLeft()
	{
		rb.velocity = new Vector2 (-moveSpeed, rb.velocity.y);
		moveVelocity = -moveSpeed;
	}

	void Jump()
	{
		rb.velocity = new Vector2 (rb.velocity.x, jumpHeight);
	}

	void GetDownP()
	{
		if(down = true)
		collider.size = new Vector3 (1.0f, 1.0f, 1.0f);
	}

}
