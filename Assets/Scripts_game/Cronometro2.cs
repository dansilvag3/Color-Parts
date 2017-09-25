using UnityEngine;
using System.Collections;

public class Cronometro2 : MonoBehaviour {

public float  cronos;
	public int    tempolimite;
	public string excronos;
	private pontos point;
	
	// Use this for initialization
	void Start () {
		
		cronos      = 35;
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
			DadosDoJogo.faseDoJogoSaved = "Delta2";
			DadosDoJogo.PontosDaFaseSaved = point.pontuacao;
			DadosDoJogo.Pontos2DaFaseSaved = point.pontuacao2;
			DadosDoJogo.Pontos3DaFaseSaved = point.pontuacao3;
			DadosDoJogo.Pontos4DaFaseSaved = point.pontuacao4;
			DadosDoJogo.Pontos5DaFaseSaved = point.pontuacao5;
			DadosDoJogo.PontosTotalSaved = point.total;
			DadosDoJogo.Savecsv();				
		}
		
		if (cronos == 0 & point.total <= 80){
			{
			Application.LoadLevel("Celta");	
		    }
		}
		
		if (cronos == 0 & point.total >= 81){
			{
			Application.LoadLevel ("Load2");
			}
		}
		
				
		
		    excronos = cronos.ToString (); 
	}
}
