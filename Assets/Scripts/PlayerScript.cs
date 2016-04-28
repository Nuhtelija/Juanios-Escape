using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float moveSpeed;
	private float moveVelocity;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	private bool doubleJumped;

	private Animator anim;

	public Transform firePoint;
	public GameObject ninjaStar;

	public float shotDelay;
	private float shotDelayCounter;

	private Rigidbody2D myrigidbody2D;

	public bool onLadder;
	public float climbSpeed;
	private float climbVelocity;
	private float gravityStore;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

		myrigidbody2D = GetComponent<Rigidbody2D> ();

		gravityStore = myrigidbody2D.gravityScale;

	}

	void FixedUpdate() {

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	
	}

	// Update is called once per frame
	void Update () {

		if (grounded)
			doubleJumped = false;

		anim.SetBool ("Grounded", grounded);

		if (Input.GetButtonDown("Jump") && grounded) {
			Jump ();
		}

		if (Input.GetButtonDown("Jump") && !doubleJumped && !grounded) {

			Jump ();
			doubleJumped = true;
		}

		moveVelocity = moveSpeed * Input.GetAxisRaw ("Horizontal");

		GetComponent<Rigidbody2D>().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
			

		if (GetComponent<Rigidbody2D> ().velocity.x > 0) 
			transform.localScale = new Vector3 (1f, 1f, 1f);

		else if (GetComponent<Rigidbody2D> ().velocity.x < 0) 
			transform.localScale = new Vector3 (-1f, 1f, 1f);

		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (ninjaStar, firePoint.position, firePoint.rotation);
			shotDelayCounter = shotDelay;
		}
		if(Input.GetKey(KeyCode.Return)) {
			shotDelayCounter -= Time.deltaTime;

			if (shotDelayCounter <= 0) {
				shotDelayCounter = shotDelay;
				Instantiate (ninjaStar, firePoint.position, firePoint.rotation);

			}
		}


		anim.SetFloat ("Speed", (GetComponent<Rigidbody2D>().velocity.x));

		if (onLadder) {
			myrigidbody2D.gravityScale = 0f;

			climbVelocity = climbSpeed * Input.GetAxisRaw ("Vertical");

			myrigidbody2D.velocity = new Vector2 (myrigidbody2D.velocity.x, climbVelocity);
		}

		if (!onLadder) {
			myrigidbody2D.gravityScale = gravityStore;
		}
	
	

	}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

	}

	void OnCollisionEnter2D(Collision2D other){

		if (other.transform.tag == "MovingPlatform") {

			transform.parent = other.transform;
		}
	}

		void OnCollisionExit2D(Collision2D other){

			if (other.transform.tag == "MovingPlatform") {

				transform.parent = null;
			}
}
}