using UnityEngine;
using System.Collections;

public class BasuraCreator : MonoBehaviour {

	public GameObject Basura1;
	public GameObject Basura2;
	public GameObject Basura3;

	private int numeroBasura;
	
	void Awake () 
	{
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
	}


	// Use this for initialization
	void Start () {
		InvokeRepeating ("GenerateBasuras", 5f, 1);
	}
	
	// Update is called once per frame
	void Update () {
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
	}
	
	public void GenerateBasuras ()
	{

		switch (numeroBasura) 
		{
		case 1:
			GameObject basura1= GameObject.Instantiate(Basura1) as GameObject;
			Vector3 posicionBasura1 = transform.position;
			posicionBasura1.x = -3.35f;
			posicionBasura1.y = -3.5f;
			basura1.transform.position = posicionBasura1;
			basura1.GetComponent<SpriteRenderer>().sortingOrder = 0;

			break;
		case 2:
			GameObject basura2= GameObject.Instantiate(Basura2) as GameObject;
			Vector3 posicionBasura2 = transform.position;
			posicionBasura2.x = -3.35f;
			posicionBasura2.y = -3.5f;
			basura2.transform.position = posicionBasura2;
			basura2.GetComponent<SpriteRenderer>().sortingOrder = 0;

			break;
		case 3:
			GameObject basura3= GameObject.Instantiate(Basura3) as GameObject;
			Vector3 posicionBasura3 = transform.position;
			posicionBasura3.x = -3.35f;
			posicionBasura3.y = -3.5f;
			basura3.transform.position = posicionBasura3;
			basura3.GetComponent<SpriteRenderer>().sortingOrder = 0;

			break;
		default:
			break;
		}
		
	}

}
