using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausar : MonoBehaviour 
{
	private bool active; // Con esta variable de tipo logico queremos ver que la accion a ejecutar es verdadera o falsa y por eso la colocamos active
	Canvas canvas;//Como nuestra funcion esta en un canvas al pulsar la letra "p" saldra nuestro menu de pause y cuando le demos en p o en el boton continue saldra el juego otra vez


	void Start () // Como el void Start se ejecuta desde el principio la pantalla de pause sale activa cuando damos play ya desaparece solo saldra a menos que pulsemos la letra p
	{
		canvas = GetComponent <Canvas> (); 
		canvas.enabled = false;
	}


	void Update ()
	{
		if (Input.GetKeyDown ("p")) 
		{
			active = !active;
			canvas.enabled = active;
			Time.timeScale = (active) ? 0 : 1f;// utilizamos un operador ternario 
		}
	}
}