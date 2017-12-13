using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena1 : MonoBehaviour
{

	void OnTriggerEnter(Collider other) // Aqui con un OnTriggerEnter queremos que cuando Garud(Personaje) entre en el cofre pase al nivel dos
	{
		if (other.tag == "Player") // aqui se dice que si el objeto que tiene el tag de player toque el cofre pase a la otra escena
		{
			SceneManager.LoadScene ("Nivel2");//Hay que tener presente que lo que esta en comillas debe ser el nombre de la escena a la cual queremos acceder porque si no es asi saldra un error en consola
		}
	}
}
