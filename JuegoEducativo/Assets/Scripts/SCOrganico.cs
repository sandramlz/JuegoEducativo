using UnityEngine;
using System.Collections;

public class SCOrganico : MonoBehaviour {

	private int score_organico;
	
	void Awake () 
	{
		score_organico = PlayerPrefs.GetInt ("score_organico");
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		score_organico = PlayerPrefs.GetInt ("score_organico");
	}
	
	void OnGUI() {
		GUI.Label (new Rect (300,200,250,250), score_organico.ToString ());
		GUIStyle style = GUI.skin.GetStyle ("label");
		style.fontSize = (int)(30.0f);
		style.normal.textColor = Color.magenta;
		GUI.color = Color.yellow;
		
	}

}
