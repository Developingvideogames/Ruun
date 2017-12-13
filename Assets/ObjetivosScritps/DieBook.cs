using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieBook : MonoBehaviour
{

	public GameObject libro;

	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Libro"))
		{
			libro.SetActive (false);
		}

	}
}
