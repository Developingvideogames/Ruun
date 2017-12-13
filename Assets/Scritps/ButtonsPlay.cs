using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsPlay : MonoBehaviour
{

	public void BotonJugar(int Niveles)// Cree un metodo publico el cual ayudara a mi boton a cambiar de escena
	{
		SceneManager.LoadScene  ("Niveles");//Hay que tener presente que lo que esta en comillas debe ser el nombre de la escena a la cual queremos acceder porque si no es asi saldra un error en consola
	}


}