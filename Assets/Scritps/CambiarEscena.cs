using UnityEngine;
using UnityEngine.Collections;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
	public void BotonJugar(int Instrucciones)
	{
		SceneManager.LoadScene ("Instrucciones");
	}

	public void BotonSalir (int Exit)
	{
		Application.Quit ();
	}
}
