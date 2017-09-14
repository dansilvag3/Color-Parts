using UnityEngine;
using System.Collections;


public class pontos : MonoBehaviour {
	
	public int pontuacao;
	public int pontuacao2;
	public int pontuacao3;
	public int pontuacao4;
	public int pontuacao5;
	public int total;
	
	public string ptazul;
	public string ptverde;
	public string ptvermelho;
	public string ptamarelo;
	public string pdark;
	public string ptotal;
	
	public Texture textgreen, textblue, textred, textyellow;
	
	// Use this for initialization
	void Start () {
		pontuacao =  0;
		pontuacao2 = 0;
		pontuacao3 = 0;
		pontuacao4 = 0;
		pontuacao5 = 0;
	    total      = 0;
		
	}
	
	void OnGUI () {
		GUI.Label (new Rect(Screen.width/7.5f,Screen.height/16,200,100),ptverde);
		GUI.Label (new Rect(Screen.width/10,Screen.height/16,200,100),ptazul);
		GUI.Label (new Rect(Screen.width/5.8f,Screen.height/16,200,100),ptamarelo);	
		GUI.Label (new Rect(Screen.width/4.8f,Screen.height/16,200,100),ptvermelho);
		GUI.Label (new Rect(Screen.width/3,Screen.height/16,200,100),ptotal);
		
		GUI.DrawTexture (new Rect(Screen.width/7.5f,Screen.height/20,10,10),textgreen);
		GUI.DrawTexture (new Rect(Screen.width/10,Screen.height/20,10,10),textblue);
		GUI.DrawTexture (new Rect(Screen.width/4.8f,Screen.height/20,10,10),textyellow);	
		GUI.DrawTexture (new Rect(Screen.width/5.8f,Screen.height/20,10,10),textred);
		
	}
	
	void Update () {
		total      = (pontuacao * 2) + (pontuacao2 * 2) + (pontuacao3 * 2) + (pontuacao4 * 2) + (pontuacao5 * 2);
		ptverde    = pontuacao.ToString  ();
		ptazul     = pontuacao2.ToString ();
		ptvermelho = pontuacao3.ToString ();
		ptamarelo  = pontuacao4.ToString ();
		pdark      = pontuacao5.ToString ();
		ptotal     = total.ToString      ();
		
	
	}		
}
