using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	public Font fonte;
	
	void OnGUI ()
	{
		const int buttonWidth  = 120;
		const int buttonHeigth = 40;
		
		GUI.skin.font = fonte;
		
		if (GUI.Button(new Rect(Screen.width / 2 - (buttonWidth /2),
		   (2 * Screen.height / 2.3f) - (buttonWidth / 2),
		    buttonWidth, buttonHeigth), "INICIAR"))
		{
			Application.LoadLevel("tutorial");	
		}
		
		
	}
}
