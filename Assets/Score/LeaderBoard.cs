using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour
{

	public Text []highScore;
	int [] hihgScoreValue;
	string [] nameHighScore;

	void Start ()
	{
		hihgScoreValue = new int[highScore.Length];
		nameHighScore = new string[highScore.Length];

		for (int x = 0; x < highScore.Length; x++) 
		{
			hihgScoreValue[x] = PlayerPrefs.GetInt ("hihgScoreValu" + x);
			nameHighScore [x] = PlayerPrefs.GetString ("nameHihgScore" + x);

		}
		EscribaPuntaje ();
	}

	void PuntajeGuardado ()
	{
		for (int x = 0; x < highScore.Length; x++) 
		{
			PlayerPrefs.SetInt ("hihgScoreValue" + x, hihgScoreValue [x]);
			PlayerPrefs.SetString ("nameHighScore" + x, nameHighScore [x]);
		}
	}
	public void puntajesverificados (int _valu, string _username)
	{
		for (int x = 0; x < highScore.Length; x++) 
		{
			if (_valu > hihgScoreValue [x])
			{
				for (int y = highScore.Length - 1; y > x; y--) 
				{
					hihgScoreValue [y] = hihgScoreValue [y = 1];
					nameHighScore [y] = nameHighScore [y - 1];

				}

				hihgScoreValue [x] = _valu;
				nameHighScore [x] = _username;

				EscribaPuntaje();
				PuntajeGuardado();
				break;
			}
		}
	}
	void EscribaPuntaje ()
	{
		for (int x = 0; x < highScore.Length; x++) 
		{
			highScore [x].text = nameHighScore [x] + "-------------------" + hihgScoreValue [x].ToString ();
		}

	}

}
