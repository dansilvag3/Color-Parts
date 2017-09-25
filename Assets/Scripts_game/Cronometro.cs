using UnityEngine;
using System.Collections;

public class Cronometro : MonoBehaviour {
	
	public float  cronos;
	public int    tempolimite;
	public string excronos;
	private pontos point;	
	
	//inicialização das variaveis
	void Start () {		
		cronos      = 30;
		tempolimite = 0;
		point= GameObject.Find("Pontos").GetComponent<pontos> ();		
	}
	
	//adicionando caracteres 
	void OnGUI () {
		
		GUI.Label (new Rect(Screen.width/2,Screen.height/16,200,100),excronos);
	}
	
	//condicionando a variavel para decisão de tela segundo sua pontuação
	void Update () {
		
		cronos -= Time.deltaTime;
		if (cronos <= tempolimite) {
			cronos = 0;		
		}
		
		if(cronos == 0) {
			DadosDoJogo.faseDoJogoSaved = "Beta";
			DadosDoJogo.PontosDaFaseSaved = point.pontuacao;
			DadosDoJogo.Pontos2DaFaseSaved = point.pontuacao2;
			DadosDoJogo.Pontos3DaFaseSaved = point.pontuacao3;
			DadosDoJogo.Pontos4DaFaseSaved = point.pontuacao4;
			DadosDoJogo.Pontos5DaFaseSaved = point.pontuacao5;
			DadosDoJogo.PontosTotalSaved = point.total;
			DadosDoJogo.Savecsv();			
		}

		if (cronos == 0 & point.total <= 50){
			{
			Application.LoadLevel("Celta");	
		    }
		}
		
		if (cronos == 0 & point.total >= 51){
			{
			Application.LoadLevel ("Load");
			}
		}
			
		
		excronos = cronos.ToString (); 
	}
}
