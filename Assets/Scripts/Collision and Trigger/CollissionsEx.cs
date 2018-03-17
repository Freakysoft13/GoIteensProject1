using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionsEx : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		print ("Entered Collission");
	}

	void OnCollisionStay(Collision collision)
	{
		print ("In collision");
	}

	void OnCollisionExit(Collision collision)
	{
		print ("Exited collision");
	}
}
