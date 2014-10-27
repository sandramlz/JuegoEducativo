using UnityEngine;
using System.Collections;

public class PapelController : MonoBehaviour {
	private int numeroBasura;
	private int score_papel;

	void Awake () 
	{
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_papel= PlayerPrefs.GetInt ("score_papel");
	}

	void Update () {
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
	}


	void OnTriggerEnter2D(Collider2D col)
	{

		if (numeroBasura == 3) 
		{
			score_papel=score_papel+1;
			PlayerPrefs.SetInt("score_papel", score_papel);
			Destroy(col.gameObject);
		}
	}
}
