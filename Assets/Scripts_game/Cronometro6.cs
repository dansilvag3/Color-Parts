using UnityEngine;
using System.Collections;

public class Cronometro6 : MonoBehaviour {

	public float  cronos;
	public int    tempolimite;
	public Font   fonte;
	
	
	// Use this for initialization
	void Start () {
		
		cronos      = 20;
		tempolimite = 0;
		
	
	}
	
	
	void OnGUI () {
		
		GUI.skin.font = fonte;
		GUI.Label (new Rect(Screen.width/2.4f,Screen.height/20,200,100),"Orange esta habilitado, para continuar compre o Game completo!");
	}
	
	// Update is called once per frame
	void Update () {
		
		cronos -= Time.deltaTime;
		if (cronos <= tempolimite) {
			cronos = 0;		
		}
		
		if (cronos == 0){
			{
			Application.LoadLevel("Alfa");	
		    }
		}
				
	}
}
