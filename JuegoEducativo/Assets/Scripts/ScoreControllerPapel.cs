using UnityEngine;
using System.Collections;

public class ScoreControllerPapel : MonoBehaviour {

	private int score_papel;
	
	void Awake () 
	{
		score_papel = PlayerPrefs.GetInt ("score_papel");
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		score_papel = PlayerPrefs.GetInt ("score_papel");
	}
	
	void OnGUI() {
		GUI.Label (new Rect (300,150,250,250), score_papel.ToString ());
		GUIStyle style = GUI.skin.GetStyle ("label");
		style.fontSize = (int)(30.0f);
		style.normal.textColor = Color.magenta;
		GUI.color = Color.yellow;
		
	}

}
