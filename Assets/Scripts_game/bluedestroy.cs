using UnityEngine;
using System.Collections;

public class bluedestroy : MonoBehaviour {

	public pontos bpontos;
	public AudioClip befect;

	// Use this for initialization
	void Start () {
		bpontos= GameObject.Find("Pontos").GetComponent<pontos> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Azul"){
			Destroy (gameObject);
			GetComponent<AudioSource>().PlayOneShot(befect, 0.9f);
			 bpontos.pontuacao2 += 2;
			
		    
    }
  }
}
