using UnityEngine;
using System.Collections;

public class Cronometro5 : MonoBehaviour {

	public float  cronos;
	public string mensagem;
	public int    tempolimite;
	
	
	// Use this for initialization
	void Start () {
		
	    cronos      = 40;
		tempolimite = 0;	
		
	}
	
	void OnGUI (){
		
		GUI.Label (new Rect(Screen.width/16 -Screen.width/2,Screen.height/1 - Screen.height/8,Screen.width*1.1f,Screen.height*2),mensagem);
	}
	
	// Update is called once per frame
	void Update () {
		
		cronos -= Time.deltaTime;
		if (cronos <= tempolimite) {
			cronos = 0;	
		}
		
		if (cronos == 0){
			{
			Application.LoadLevel("Demo");	
		    }
		}
	
		
	}
 
}