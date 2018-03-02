using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
	Material m_Material;
	float red = 0.1f;
	float green = 0.345f;
	float blue = 0.71f;
	float alpha = 1.0f;
	public float colorArgument  = 0.001f;
	// Use this for initialization
	void Start () 
	{
		m_Material = GetComponent<Renderer> ().material;

	}
	
	// Update is called once per frame
	void Update () 
	{
		//m_Material.color = Color.blue;
		//m_Material.color = new Color (0.21f, 0.112f, 0.332f, 1.0f);
		//ColorCorection();
	}
	void OnMouseEnter()
	{
		m_Material.color = new Color (0.21f, 0.112f, 0.332f, 1.0f);
	}
	void OnMouseExit()
	{
		m_Material.color = new Color (1.0f, 1.0f, 0.332f, 1.0f);
	}
	void ColorCorection()
	{
		m_Material.color = new Color (red+colorArgument, green+colorArgument, blue+colorArgument, alpha);
	}
}
