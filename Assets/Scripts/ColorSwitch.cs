using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour {
	Material m_Material;
	// Use this for initialization
	void Start () {
		m_Material = GetComponent<Renderer> ().material;
		m_Material.color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
