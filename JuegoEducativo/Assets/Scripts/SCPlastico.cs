using UnityEngine;
using System.Collections;

public class SCPlastico : MonoBehaviour {

	private int score_plastico;
	
	void Awake () 
	{
		score_plastico = PlayerPrefs.GetInt ("score_plastico");
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		score_plastico = PlayerPrefs.GetInt ("score_plastico");
	}
	
	void OnGUI() {
		GUI.Label (new Rect (300,260,250,250), score_plastico.ToString ());
		GUIStyle style = GUI.skin.GetStyle ("label");
		style.fontSize = (int)(30.0f);
		style.normal.textColor = Color.magenta;
		GUI.color = Color.yellow;
		
	}

}
