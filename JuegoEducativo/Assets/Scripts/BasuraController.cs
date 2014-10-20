using UnityEngine;
using System.Collections;

public class BasuraController : MonoBehaviour {

	// Use this for initialization


	void Start () {
		Invoke ("DestruirBasura", 1.5f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector2(0,  1* Time.deltaTime));
	}

	void OnTriggerEnter2D(Collider2D objeto){
			
			DestruirBasura ();
			
		}

	void DestruirBasura(){
		
		Destroy (gameObject);
		
	}

}
