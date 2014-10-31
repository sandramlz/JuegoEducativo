using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	private int numeroBasura;
	private int score_plastico;
	private int score_organico;
	private int score_papel;
	private int puedeDisparar=1;

	private Animator animator;
	private bool isPress=false;

	public GameObject dialogo2;
	public GameObject dialogo3;
	private int ScoreTotal;

	void Awake () 
	{
		puedeDisparar= 1;
		numeroBasura = PlayerPrefs.GetInt ("numeroBasura");
		score_plastico = PlayerPrefs.GetInt ("score_plastico");
		score_organico = PlayerPrefs.GetInt ("score_organico");
		score_papel = PlayerPrefs.GetInt ("score_papel");

		animator = GetComponent<Animator>();
//		isPress=false;
//		animator.SetBool("isPress", isPress);

	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		animator.SetBool("isPress", isPress);

		dialogo2.gameObject.active = false;
		dialogo3.gameObject.active = false;

		ScoreTotal = score_plastico + score_organico + score_papel;

		if (ScoreTotal < 5 && ScoreTotal>0) {
			dialogo2.gameObject.active = true;
		}
		else{
			dialogo3.gameObject.active = true;
		}

	}

	void OnMouseOver()
	{
		isPress=true;
		animator.SetBool("isPress", isPress);
		Debug.Log("Estoy Oprimido");

	}

	void OnMouseExit()
	{
		isPress=false;
		animator.SetBool("isPress", isPress);
		Debug.Log("Estoy Oprimido");
		
	}

	void OnMouseDown() {
		
		PlayerPrefs.SetInt("numeroBasura", 0);
		PlayerPrefs.SetInt("puedeDisparar", 1);
		PlayerPrefs.SetInt("score_plastico", 0);
		PlayerPrefs.SetInt("score_organico", 0);
		PlayerPrefs.SetInt("score_papel", 0);

		Debug.Log("Cargar nivel");
		Application.LoadLevel("Level1");
		
	}

}
