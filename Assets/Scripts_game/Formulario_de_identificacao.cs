using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;
 


public class Formulario_de_identificacao : MonoBehaviour {
	
	public string labelNomeDoJogador="Nome";
	public string labelIdadeDoJogador="Idade";
	public string nomeDoJogador="";
	public string idadeDoJogador="";
	public string faseDoJogo;
	public string tempoDaFase;
	public string PontosDaFase;
	public Font fonte;
	
	
	
	//
	//Use this for initialization
	void Start () {
				
	}
	
	void OnGUI () {
		
		//Formulario pre-game
	
		nomeDoJogador = GUI.TextField (new Rect(Screen.width/2.6f,Screen.height/18,260,24),nomeDoJogador,30);		
		idadeDoJogador = GUI.TextField (new Rect(Screen.width/2.6f,Screen.height/8,40,24),idadeDoJogador,3);
		GUI.Label (new Rect(Screen.width/3.2f,Screen.height/18.9f,200,200),labelNomeDoJogador);
		GUI.Label (new Rect(Screen.width/3.2f,Screen.height/8,200,200),labelIdadeDoJogador);
		
		
		const int buttonWidth  = 120;
		const int buttonHeigth = 40;
		
		GUI.skin.font = fonte;
			
		
		if  (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth /2),
		    (2 * Screen.height / 2.3f) - (buttonWidth / 2),
		    buttonWidth, buttonHeigth), "Proximo"))
		{		
			DadosDoJogo.nomeDoJogadorSaved = nomeDoJogador;
			DadosDoJogo.idadeDoJogadorSaved = idadeDoJogador;
			Application.LoadLevel("tutorial");	
		}	
		
	
	}
	
	void Update () {
		
	}
	
	
	
}