using UnityEngine;
using System.Collections;


public class colordestroy : MonoBehaviour {
	
	public pontos gpontos;
	public AudioClip gefect;

	// Use this for initialization
	void Start () {
		gpontos = GameObject.Find("Pontos").GetComponent<pontos> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Verde"){
			Destroy (gameObject);
			GetComponent<AudioSource>().PlayOneShot(gefect, 0.9f);
			gpontos.pontuacao += 5;
    }
  }
}