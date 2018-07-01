using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

	public float horizontal;
	public float velocidade;
	private Rigidbody2D rigidbodyPlayer;

	// Use this for initialization
	void Start ()
	{
		rigidbodyPlayer = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		rigidbodyPlayer.velocity = new Vector2 (horizontal * velocidade, rigidbodyPlayer.velocity.y);

	}

	public void atirar ()
	{
		// Função responsável por atirar
	}

	public void pular ()
	{
		// Função responsável por pular
	}


}
