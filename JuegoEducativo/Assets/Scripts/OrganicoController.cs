using UnityEngine;
using System.Collections;

public class OrganicoController : MonoBehaviour {

	private int numeroBasura;
	private int score_organico;
	
	void Awake () 
	{
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_organico= PlayerPrefs.GetInt ("score_organico");
	}

	void Update () {
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (numeroBasura == 1) 
		{
			Destroy (col.gameObject);
			score_organico=score_organico+1;
			PlayerPrefs.SetInt("score_organico", score_organico);
		}
	}
	
}
