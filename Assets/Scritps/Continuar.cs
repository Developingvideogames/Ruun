using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continuar : MonoBehaviour 
{
	public void BotonCambiarMenu(int Menu)// Cree una funcion la cual me va a ayudar a pasar a otra escena
	{
		SceneManager.LoadScene ("Menu");// Aqui se cargara la escena a la cual estoy llamando que se llama "Menu"

	}

}
