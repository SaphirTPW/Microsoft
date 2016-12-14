using UnityEngine;
using System.Collections;

public class CharacterControls : MonoBehaviour {

	private float moveSpeed = 3.0f;
	//private float moveVelocity = 1.0f;
	private float jumpHeight = 10.0f;
	private Rigidbody2D rb;
	private isGrounded ground;
	private BoxCollider2D collid;
	//private bool down = false;
	//public BoxCollider2D collid2;
	public GameObject player;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		ground = GetComponent<isGrounded> ();
		collid = GetComponent<BoxCollider2D> ();

	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		//moveVelocity = 0.5f;

		if (Input.GetKey (KeyCode.D))
			MoveRight ();

		if (Input.GetKey (KeyCode.A))
			MoveLeft ();
		
	
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space) && ground.Grounded())
			Jump ();
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			GetDownP ();
		}
		if (Input.GetKeyDown (KeyCode.W))
			GetUpP ();
		
	}

	void MoveRight()
	{
		//rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);
		/*rb.AddForce (Vector3.right * moveSpeed);
		moveVelocity = moveSpeed;*/
		transform.position += Vector3.right * moveSpeed * Time.deltaTime;

	}

	void MoveLeft()
	{
		/*rb.AddForce (Vector3.left * moveSpeed);
		moveVelocity = -moveSpeed;*/
		transform.position += Vector3.left * moveSpeed * Time.deltaTime;

	}

	void Jump()
	{
		rb.velocity = new Vector2 (rb.velocity.x, jumpHeight);
	}

	void GetDownP()
	{
		
			collid.size = new Vector3 (1.0f, 1.0f, 1.0f);
	}

	void GetUpP()
	{
		collid.size = new Vector3 (1.0f, 2.0f, 1.0f);
	}

}
