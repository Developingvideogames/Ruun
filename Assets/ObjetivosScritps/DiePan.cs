using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiePan : MonoBehaviour 
{

	public GameObject pan;// Creamos una variable publica de tipo Object

	void OnTriggerEnter (Collider other)//Con el ontrigger enter lo que queremos es que cuando entre en el GameObject cumpla una funcion
	{
		if(other.CompareTag("Pan"))// Entonces si other.CompareTag collisiona con pan se desactiva el objeto
		{
			pan.SetActive (false);// Aqui colcomos el objeto como falso
		}

	}
}
