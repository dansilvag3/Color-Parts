using UnityEngine;
using System.Collections;

public class yellowdestroy : MonoBehaviour {
	
	public pontos ypontos;
	public AudioClip aefect;

	// Use this for initialization
	void Start () {
	ypontos= GameObject.Find("Pontos").GetComponent <pontos> ();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
    void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Amarelo"){
			Destroy (gameObject);
			GetComponent<AudioSource>().PlayOneShot(aefect, 0.9f);
			 ypontos.pontuacao3 += 4;
			
		    
    }
  }
}
