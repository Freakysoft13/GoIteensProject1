using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3_Ex1 : MonoBehaviour
{

	 int a = 10;
	 int b = 43;

	void Start ()
	{
		if (a != b) 
		{
			if (a + b <= 52) {
				print ("Lemon");
			} else if (a / 2 - b == -38 && a * b < 100) {
				print ("Apple");
			} else if (b >= a && b <= 0) {
				print ("Pear");
			} else if (a * b < 25 || a == 10) {
				print ("Kivi");
			} else
				print ("Potato");
		
		} 
		else
			print ("Numbers are equal");
	}

}
