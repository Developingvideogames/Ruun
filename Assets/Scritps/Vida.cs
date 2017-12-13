using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
	public static int VidaTotal = 100;// Aqui veremos que la cantidad de vida que tiene el player es 100
	public Slider BarraVida;// Cree una variable que me indica en el unity donde va la barra de via
	public GameObject Player;// Aqui es para que en el unity quede el espacio de donde va el player y la funcion que cumplira el slider con el
	public GameObject GameOver;


	void OnTriggerEnter(Collider other)//Con el Ontriggerenter para que cuando el player pase osea entre en el objeto pase algo
	{
		if (other.CompareTag ("Potion")) //aqui decimos que si other (que es cualquier cosa ) colisiona con el tag potion se le suma al personaje 10 de salud
		{
			VidaTotal += 10;// se le suma 10 de salud al player
			Debug.Log ("Total vida : " + VidaTotal);//Aqui mandara un mensaje a la consola enseñando que se le sumaron 10 de salud
			BarraVida.value = VidaTotal;// Aqui la barra de vida aumentara los 10 de salud siempre y cuando este en menos de 100

		} 

		if (other.CompareTag ("Enemy")) // Aqui decimos que si other colisiona con Enemy perdera 50 de salud
		{
			VidaTotal -= 50;// se muestra en la consola los 50 que le quedan de salud
			Debug.Log ("Total vida" + VidaTotal);// aqui sale un mensaje en la consola que muestra lo que tiene de salud
			BarraVida.value = VidaTotal;// Aqui la barra de vida disminuira un 50%
		}


		else 
		{// Aqui decimos que si no paso lo anterior entonces pasa lo siguiente

			if (other.CompareTag ("Veneno")) //Si other colisiona con algo que tenga el tag veneno pierde 10 de  vida
			{


				VidaTotal -= 10;// se le restan 10 de vida
				Debug.Log ("Total vida : " + VidaTotal);// sale el mensaje en la consola que dice cuanto le queda
				BarraVida.value = VidaTotal;// la barra de vida disminulle

			}
		}


	}
}
	/*
	void Update ()
	{
		BarraVida.value = VidaTotal;// Como el update repite la accion aqui se quiere actualizar
	}
}
*/