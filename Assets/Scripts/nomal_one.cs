using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nomal_one : MonoBehaviour
{
	int a = 1990;
	//Рік вашого народження
	int b = 2018;
	//Поточний рік
	int c;

	string firstName = "Bogdan";
	//Ім'я
	string secondName = "Rybak";
	//Прізвище
	string fullName;

	void Start ()
	{		
		//ТУТ ВИКЛИКАЄТЕ ВСІ СВОЇ ФУНКЦІЇ
		FirstStep ();
		SecondStep ();
		ThirdStep ();
		FourthStep ();
	}

	void FirstStep ()
	{
		//Вітаємось зі світом :)
		print ("Hello World!");
	}

	void SecondStep ()
	{
		//додаємо змінні вашого імені і прізвища, потім виводимо їх на екран в консолі
		fullName = firstName + " " + secondName;
		print ("My full name is " + fullName);
	}

	void ThirdStep ()
	{
		//вираховуємо скільки вам років, та виводимо це в консоль
		c = b - a;
		print ("i Am " + c + " Years old");
	}

	void FourthStep ()
	{
		if (a <= b && a >= 2001) {
			print ("You were born in 21 century");
		} else if (a <= 2000 && a >= 1901) {
			print ("I Was born in 20 century");
		} else if (a > b) {
			print ("Hello from the Future!");
		} else if (a < 1900) {
			print ("I`m too old for this (");
		}
			
	}
}
