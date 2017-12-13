using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	public float thrust;
	public Rigidbody rb;

	public ScoreManager theScoreManager;
	public LeaderBoard leaderboard;

	public InputField playerName;




	void Start()
	{
		rb = GetComponent<Rigidbody>();
		theScoreManager = FindObjectOfType<ScoreManager> ();
	}

	public void RestaurarGameCo ()
	{
		StartCoroutine ("RestaurarGameCo");
	



		theScoreManager.scoreIncrementacion = false;

		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncrementacion = true;

	}

	void Update()
	{
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);


	}

	void FixedUpdate()
	{
		if (Input.GetButtonDown("Jump") && estaEnElPiso == true)
		{
			rb.AddForce(0, thrust, 2, ForceMode.Impulse);
		}
		if (Input.GetButtonDown("Jump") && estaEnElPiso == true)
		{
			rb.AddForce(0, thrust, 2, ForceMode.Impulse);
		}
	}

	public bool estaEnElPiso = false;

	void OnCollisionStay(Collision collision)
	{
		if (collision.collider.CompareTag("Piso" ))
		{

			estaEnElPiso = true;
			Debug.Log("Tocando el piso " + estaEnElPiso);
		}    
	}

	void OnCollisionExit(Collision cosito)
	{

		estaEnElPiso = false;
		print("No longer in contact with " + estaEnElPiso);
	}
}
