using UnityEngine;
using System.Collections;

public class LavaDestroy : MonoBehaviour {

	public pontos lavpontos;
	public AudioClip lavefect;

	// Use this for initialization
	void Start () {
	lavpontos = GameObject.Find("Pontos").GetComponent <pontos> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
    void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Black"){
			Destroy (gameObject);
			GetComponent<AudioSource>().PlayOneShot(lavefect, 0.9f);
			 lavpontos.pontuacao5 -= 10;
			
		    
    }
  }
}
