using UnityEngine;
using System.Collections;

public class redestroy : MonoBehaviour {
	
	public pontos rpontos;
	public AudioClip refect;

	// Use this for initialization
	void Start () {
	rpontos = GameObject.Find("Pontos").GetComponent <pontos> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
    void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Vermelho"){
			Destroy (gameObject);
			GetComponent<AudioSource>().PlayOneShot(refect, 0.9f);
			 rpontos.pontuacao4 += 1;
			
		    
    }
  }
}
