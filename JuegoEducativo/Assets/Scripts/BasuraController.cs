using UnityEngine;
using System.Collections;

public class BasuraController : MonoBehaviour {

	// Use this for initialization


	void Start () {
		Invoke ("DestruirBasura", 10f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector2(0,  1* Time.deltaTime));
	}

	void OnTriggerEnter2D(Collider2D objeto){
			Debug.Log("he entrado");
			DestruirBasura ();
			
		}

	void DestruirBasura(){
		
		Destroy (gameObject);
		
	}

}
