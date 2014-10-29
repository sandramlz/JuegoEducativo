using UnityEngine;
using System.Collections;

public class PapelController : MonoBehaviour {
	private int numeroBasura;
	private int score_papel;
	private int puedeDisparar;

	void Awake () 
	{
		puedeDisparar= PlayerPrefs.GetInt ("puedeDisparar");
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_papel= PlayerPrefs.GetInt ("score_papel");
	}

	void Update () {
		puedeDisparar= PlayerPrefs.GetInt ("puedeDisparar");
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_papel= PlayerPrefs.GetInt ("score_papel");
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		switch (numeroBasura) 
		{
		case 1:
			Debug.Log("Basura tipo 1");
			break;
		case 2:
			Debug.Log("Basura tipo 2");
			break;
		case 3:
			Debug.Log("Basura tipo 3");
			score_papel=score_papel+1;
			PlayerPrefs.SetInt("score_papel", score_papel);
			break;
		default:
			break;
		}

		puedeDisparar = 1;
		PlayerPrefs.SetInt("puedeDisparar", puedeDisparar);
		Destroy (col.gameObject);
	}
}
