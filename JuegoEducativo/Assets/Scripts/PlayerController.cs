using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float velocidad = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Movimiento
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Translate(new Vector3(velocidad * Time.deltaTime,0,0));
		}
		
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Translate(new Vector3(-velocidad * Time.deltaTime,0,0));
		}
		
		else if (!Input.anyKey){
		}

	
	}
}
