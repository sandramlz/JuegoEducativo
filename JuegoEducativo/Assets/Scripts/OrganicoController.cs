using UnityEngine;
using System.Collections;

public class OrganicoController : MonoBehaviour {

	private int numeroBasura;
	private int score_organico;
	private int puedeDisparar;
	
	void Awake () 
	{
		puedeDisparar= 1;
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_organico= PlayerPrefs.GetInt ("score_organico");
	}

	void Update () {
		puedeDisparar= PlayerPrefs.GetInt ("puedeDisparar");
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_organico= PlayerPrefs.GetInt ("score_organico");
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
			score_organico=score_organico+1;
			PlayerPrefs.SetInt("score_organico", score_organico);
			break;
		case 3:
			Debug.Log("Basura tipo 3");
			break;
		default:
			break;
		}
//		puedeDisparar = 1;
//		PlayerPrefs.SetInt("puedeDisparar", puedeDisparar);
		Destroy (col.gameObject);

	}
	
}
