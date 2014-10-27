using UnityEngine;
using System.Collections;

public class PlasticoController : MonoBehaviour {
	private int numeroBasura;
	private int score_plastico;
	
	void Awake () 
	{
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_plastico= PlayerPrefs.GetInt ("score_plastico");
	}

	void Update () {
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (numeroBasura == 1) 
		{
		
			Destroy (col.gameObject);
			score_plastico=score_plastico+1;
			PlayerPrefs.SetInt("score_plastico", score_plastico);

		}
	}

}
