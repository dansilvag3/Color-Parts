using UnityEngine;
using System.Collections;

public class dark_destroy : MonoBehaviour {

	public pontos dpontos;
	public AudioClip defect;

	// Use this for initialization
	void Start () {
		dpontos = GameObject.Find("Pontos").GetComponent<pontos> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Verde"){
			Destroy (gameObject);
			GetComponent<AudioSource>().PlayOneShot(defect, 0.9f);
			dpontos.pontuacao5 -= 10;
    }
  
	
	    if (col.gameObject.tag == "Amarelo"){
			Destroy (gameObject);
			GetComponent<AudioSource>().PlayOneShot(defect, 0.9f);
			dpontos.pontuacao5 -= 8;
			
		    
    }
		
		if (col.gameObject.tag == "Azul"){
			Destroy (gameObject);
			GetComponent<AudioSource>().PlayOneShot(defect, 0.9f);
			dpontos.pontuacao5 -= 6;
			
		    
    }
		
		if (col.gameObject.tag == "Vermelho"){
			Destroy (gameObject);
			GetComponent<AudioSource>().PlayOneShot(defect, 0.9f);
			dpontos.pontuacao5 -= 2;
			
		    
    }
  }
}
