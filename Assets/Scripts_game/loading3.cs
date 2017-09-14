using UnityEngine;
using System.Collections;

public class loading3 : MonoBehaviour {

			public float  cronos;
	public int    tempolimite;
	public string excronos;
	
	
	// Use this for initialization
	void Start () {
		
		cronos      = 18;
		tempolimite = 0;
	
	}
	
	
	// Update is called once per frame
	void Update () {
		
		cronos -= Time.deltaTime;
		if (cronos <= tempolimite) {
			cronos = 0;
			Application.LoadLevel("Boss");	
		}
		
		
	}
}
