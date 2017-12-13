using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour 
{


	public GameObject manzana;


	void OnTriggerEnter (Collider other)
	{
		if(other.CompareTag("Manzana"))
		{
			manzana.SetActive (false);
		}

	}

}
