using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {

	public float  cronos;
	public int    tempolimite;
	public string excronos;
	
	
	// Use this for initialization
	void Start () {
		
		cronos      = 16;
		tempolimite = 0;
	
	}
	
	
	void OnGUI () {
		GUI.Label (new Rect(Screen.width/2,Screen.height/16,200,100),excronos);
	}
	
	// Update is called once per frame
	void Update () {
		
		cronos -= Time.deltaTime;
		if (cronos <= tempolimite) {
			cronos = 0;
			Application.LoadLevel("Delta");	
		}
		
		
	}
}
