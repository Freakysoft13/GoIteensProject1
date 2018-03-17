using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEx : MonoBehaviour
{

	public float _forece = 10f;
	void OnTriggerStay (Collider other)
	{
other.attachedRigidbody.AddForce (Vector3.up*_forece,ForceMode.Acceleration);}

}
