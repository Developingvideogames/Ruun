using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarNivel3 : MonoBehaviour
{

	void OnTriggerEnter(Collider other) // Aqui con un OnTriggerEnter queremos que cuando Garud(Personaje) entre en el cofre pase al nivel dos
	{
		if (other.tag == "Player") // aqui se dice que si el objeto que tiene el tag de player toque el cofre pase a la otra escena
		{
			SceneManager.LoadScene ("Nivel3");
		}
	}
}
