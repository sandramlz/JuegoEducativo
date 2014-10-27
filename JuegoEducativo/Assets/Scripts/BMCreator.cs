using UnityEngine;
using System.Collections;

public class BMCreator : MonoBehaviour {

	public GameObject Basura1;
	public GameObject Basura2;
	public GameObject Basura3;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating ("GenerateBasuras", 0.5f, 3);
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void GenerateBasuras ()
	{
		int numeroBasura = Random.Range (1, 4);
		PlayerPrefs.SetInt("numeroBasura", numeroBasura);
		
		switch (numeroBasura) 
		{
		case 1:
			GameObject basura1= GameObject.Instantiate(Basura1) as GameObject;
			Vector3 posicionBasura1 = transform.position;
			posicionBasura1.x = -3.75f;
			posicionBasura1.y = 3.5f;
			basura1.transform.position = posicionBasura1;
			basura1.GetComponent<SpriteRenderer>().sortingOrder = 0;

			Destroy(basura1.gameObject,2f);

			break;
		case 2:
			GameObject basura2= GameObject.Instantiate(Basura2) as GameObject;
			Vector3 posicionBasura2 = transform.position;
			posicionBasura2.x = -3.75f;
			posicionBasura2.y = 3.5f;
			basura2.transform.position = posicionBasura2;
			basura2.GetComponent<SpriteRenderer>().sortingOrder = 0;

			Destroy(basura2.gameObject,2f);
			break;
		case 3:
			GameObject basura3= GameObject.Instantiate(Basura3) as GameObject;
			Vector3 posicionBasura3 = transform.position;
			posicionBasura3.x = -3.75f;
			posicionBasura3.y = 3.5f;
			basura3.transform.position = posicionBasura3;
			basura3.GetComponent<SpriteRenderer>().sortingOrder = 0;

			Destroy(basura3.gameObject,2f);
			break;
		default:
			break;
		}
		
	}}
