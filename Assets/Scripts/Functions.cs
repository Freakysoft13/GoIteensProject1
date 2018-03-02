using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {

	void Start () 
	{
		print ("1");
	}
	
	void Update () 
	{
		print ("2");
	}

	void Awake ()
	{
		print ("3");
	}

	void FixedUpdate()
	{
		print ("4");
	}
}
