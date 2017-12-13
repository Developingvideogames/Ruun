using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieCofre : MonoBehaviour
{

	public GameObject cofre;

	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Cofre"))
		{
			cofre.SetActive (false);
		}

	}
}
