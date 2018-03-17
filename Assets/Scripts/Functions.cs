using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
	int health;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			health = health - 10;
			if (health > 20) {
				print (health);
			} else if (health == 20) {
			}
		}
	}

}
