using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue2 : MonoBehaviour
{

	public void ContinuarJuego (int Continue)
	{
		Application.LoadLevel("Niveles");
	}

	public void ContinuaJuego (int Continue)
	{
		Application.LoadLevel("Nivel2");
	}

	public void ContinuaarJuego (int Continue)
	{
		Application.LoadLevel("Nivel3");
	}
}
/* Cree un solo codigo para los tres botones de continue de mis tres niveles en fin cada boton debe tener un 
nombre diferente porque lo mas seguro es que salga error */