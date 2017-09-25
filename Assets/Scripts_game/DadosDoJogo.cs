using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public static class DadosDoJogo {
	
	public static string nomeDoJogadorSaved="";
	public static string idadeDoJogadorSaved="";
	public static string faseDoJogoSaved;
	public static float tempoDaFaseSaved;
	public static int PontosDaFaseSaved;
	public static int Pontos2DaFaseSaved;
	public static int Pontos3DaFaseSaved;
	public static int Pontos4DaFaseSaved;
	public static int Pontos5DaFaseSaved;
	public static int PontosTotalSaved;
		
	public static void Savecsv() {
    	string filePath = @"dados_coletados.csv";  
        string delimiter = ",";  
 
        string[][] output = new string[][]{  
             new string[]{
				nomeDoJogadorSaved, 
				idadeDoJogadorSaved, 
				faseDoJogoSaved.ToString(),
				PontosDaFaseSaved.ToString(),				
				Pontos2DaFaseSaved.ToString(),
				Pontos3DaFaseSaved.ToString(),
				Pontos4DaFaseSaved.ToString(),
			    Pontos5DaFaseSaved.ToString(),
				PontosTotalSaved.ToString()
			}
        };  
         
		int length = output.GetLength(0);  
        StringBuilder sb = new StringBuilder();  
        for (int index = 0; index < length; index++)  
          sb.AppendLine(string.Join(delimiter, output[index]));  
 
        File.AppendAllText(filePath, sb.ToString());                 
     }
}



