using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ads : MonoBehaviour
{
	/*
	// Use this for initialization
	void Start ()
	{
		if (Advertisement.IsReady()) {
			Advertisement.Show ();
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void exibirAnuncio ()
	{
		Advertisement.Show ();
	}*/
		
	private int idRecompensa;

	public void setIdRecompensa(int idRecompensa){
		this.idRecompensa = idRecompensa;
	}

	public void mostrarAds (string pularVideo)
	{

		if (string.IsNullOrEmpty (pularVideo)) {
			pularVideo = null;
		}

		ShowOptions opcoes = new ShowOptions ();
		opcoes.resultCallback = mostrarResultadoAds;

		Advertisement.Show (pularVideo, opcoes);
	}

	public void mostrarResultadoAds (ShowResult resultado)
	{

		switch (resultado) {
		case ShowResult.Failed:
			// O vídeo não pode ser carregado (normalmente por falta de internet)
			break;
		case ShowResult.Finished:
			// O vídeo foi assistido até o final
			switch (idRecompensa) {
			case 1:
				print ("Você ganhou moedas!");
				break;
			}

			break;
		case ShowResult.Skipped:
			// Caso o usuário pule o anúncio é bom chamar outra cena depois dele fechar o anúncio
			break;
		}
		
	}


}
