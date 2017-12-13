using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieQueso : MonoBehaviour 
{
	public GameObject queso;


	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Queso"))
		{
			queso.SetActive (false);
		}

	}
}
