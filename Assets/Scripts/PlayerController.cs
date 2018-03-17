using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	/*
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
    */
	void Update()
	{
		
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.left * speed);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (Vector3.right * speed);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.back * speed);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.forward * speed);
		}
	}
}