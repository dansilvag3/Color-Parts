using UnityEngine;
using System.Collections;

public class Cronometro3 : MonoBehaviour {

	public float  cronos;
	public int    tempolimite;
	public string excronos;
	private pontos point;
	
	// Use this for initialization
	void Start () {
		
		cronos      = 50;
		tempolimite = 0;
		point= GameObject.Find("Pontos").GetComponent<pontos> ();
	
	}
	
	
	void OnGUI () {
		GUI.Label (new Rect(Screen.width/2,Screen.height/16,200,100),excronos);
	}
	
	// Update is called once per frame
	void Update () {
		
		cronos -= Time.deltaTime;
		if (cronos <= tempolimite) {
			cronos = 0;		
		}
		
		if(cronos == 0) {
			DadosDoJogo.faseDoJogoSaved = "Bravo3";
			DadosDoJogo.PontosDaFaseSaved = point.pontuacao;
			DadosDoJogo.Pontos2DaFaseSaved = point.pontuacao2;
			DadosDoJogo.Pontos3DaFaseSaved = point.pontuacao3;
			DadosDoJogo.Pontos4DaFaseSaved = point.pontuacao4;
			DadosDoJogo.Pontos5DaFaseSaved = point.pontuacao5;
			DadosDoJogo.PontosTotalSaved = point.total;
			DadosDoJogo.Savecsv();			
		}
		
		if (cronos == 0 & point.total <= 100){
			{
			Application.LoadLevel("Celta");	
		    }
		}
		
		if (cronos == 0 & point.total >= 101){
			{
			Application.LoadLevel ("Load3");
			}
		}
		
				
		
		    excronos = cronos.ToString (); 
	}
}
