using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
	public Text scoreText;//Esta variable y la de aqui abajo son para agregar en el unity los textos de score y high score
	public Text highScoreTExt;

	public float scoreCount;// Aqui nos enseñara en unity los valores del score y high score 
	public float highScoreCount;

	public float pointSecond;// Esto es para que se sume el tiempo en el score 

	public bool scoreIncrementacion;// Esta sera una variable logica para saber si es verdadero  el objeto utilizado


	void Start ()
	{

		highScoreCount = PlayerPrefs.GetInt ("HighScore");

	}


	void Update () 
	{
		if (scoreIncrementacion) 
		{

			scoreCount += pointSecond * Time.deltaTime;
		}

		if (scoreCount > highScoreCount)
		{
			highScoreCount = scoreCount;
			PlayerPrefs.SetFloat ("HighScore", highScoreCount);
		}

		scoreText.text = " Score : " + Mathf.Round (scoreCount);
		highScoreTExt.text = "High Score : " + highScoreCount;
	}
}
