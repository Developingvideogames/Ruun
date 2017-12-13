using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slug : MonoBehaviour 

{

	public GameObject Player;
	public Transform target;
	public float speed;
	public float DistanciaSlug;
	void Start()
	{

		Player = GameObject.FindGameObjectWithTag ("Player");

		target = Player.transform;


		Debug.Log (target.transform);
		if (Player)
		{	
			Debug.Log ("Si encontre PLayer");
		}
		else
		{
			Debug.Log ("No encontre nada");
		}

	}

	void Update ()
	{

		float dist = Vector3.Distance (target.position, transform.position);
		if (dist >DistanciaSlug)
		{


			float step = speed * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		}
	}

}