using UnityEngine;
using System.Collections;

public class PlasticoController : MonoBehaviour {
	private int numeroBasura;
	private int score_plastico;
	private int puedeDisparar;
	
	void Awake () 
	{
		puedeDisparar= 1;
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_plastico= PlayerPrefs.GetInt ("score_plastico");
	}

	void Update () {
		puedeDisparar= PlayerPrefs.GetInt ("puedeDisparar");
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_plastico= PlayerPrefs.GetInt ("score_plastico");
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		switch (numeroBasura) 
		{
		case 1:
			Debug.Log("Basura tipo 1");
			score_plastico=score_plastico+1;
			PlayerPrefs.SetInt("score_plastico", score_plastico);
			break;
		case 2:
			Debug.Log("Basura tipo 2");
			break;
		case 3:
			Debug.Log("Basura tipo 3");
			break;
		default:
			break;
		}

		puedeDisparar = 1;
		PlayerPrefs.SetInt("puedeDisparar", puedeDisparar);
		Destroy (col.gameObject);
	}

}
