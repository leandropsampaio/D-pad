using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comandos : MonoBehaviour
{

	private playerController playerController;
	public string nomeBotao;

	// Use this for initialization
	void Start ()
	{
		// Criando variável do tipo "playerController", para poder chamar as funções posteriormente
		playerController = FindObjectOfType (typeof(playerController)) as playerController;
	}

	public void aoTocar ()
	{

		switch (nomeBotao) {
		case "esquerdo":
			playerController.horizontal = -1;

			break;
		case "direito":
			playerController.horizontal = 1;

			break;
		case "btnA":
			playerController.atirar ();

			break;
		case "btnB":
			playerController.pular ();

			break;
		}

	}

	public void aoTirar ()
	{

		switch (nomeBotao) {
		case "esquerdo":
			playerController.horizontal = 0;

			break;
		case "direito":
			playerController.horizontal = 0;

			break;
		case "btnA":


			break;
		case "btnB":


			break;
		}
	}
}
