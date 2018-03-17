using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{

	int health = 10;

	bool alive = true;
	bool buff = false;

	float a;
	float b;
	float c;
	public float speed;

	Material m_Material;
	public Light m_Light;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Awake ()
	{
		
	}

	void FixedUpdate ()
	{
		
	}

	void Update ()
	{
		
	}

	void MyFunction1 ()
	{
		m_Light.gameObject.SetActive (true);
	}

	void MyFunction2 ()
	{
		m_Material = GetComponent<Renderer> ().material;
		m_Material.color = Color.green;
	}

	void MyFunction3 ()
	{
		if (Input.GetKeyDown (KeyCode.Space) && alive) { 
			health--;
			print (health);
		} 
		else if (health <= 0) 
		{
			alive = false;
			print ("dead");
		}
	}

	void MyFunction4 ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}

