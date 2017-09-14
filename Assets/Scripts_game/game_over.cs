using UnityEngine;
using System.Collections;

public class game_over : MonoBehaviour {

	
	void OnGUI ()
	{
		const int buttonWidth  = 120;
		const int buttonHeigth = 40;
		
		//Reiniciar a fase
		if (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth /2),
		   (2 * Screen.height / 3) - (buttonWidth / 2),
		    buttonWidth, buttonHeigth), "REINICIAR"))
		{
			Application.LoadLevel("Bheta");	
		}
		
		//Sair do Jogo
		if (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth /2),
		   (2 * Screen.height / 2.3f) - (buttonWidth / 2),
		    buttonWidth, buttonHeigth), "SAIR"))
		{
			Application.LoadLevel("Alfa");	
		}
		
		
	}
}
