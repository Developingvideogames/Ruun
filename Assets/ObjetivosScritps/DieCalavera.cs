using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieCalavera : MonoBehaviour
{

	public GameObject calavera;

	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Calavera"))
		{
			calavera.SetActive (false);
		}

	}
}
