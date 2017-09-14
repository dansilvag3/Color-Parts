using UnityEngine;
using System.Collections;

public class informativo : MonoBehaviour {

	public Font fonte;
	public string info;
	
	void OnGUI ()
	{
		const int buttonWidth  = 120;
		const int buttonHeigth = 40;
		GUI.skin.font = fonte;
		GUI.Label (new Rect(Screen.width/2.3f,Screen.height/1.5f,200,100),info);
		
		if (GUI.Button(new Rect(2.5f* Screen.width / 3.5f -(buttonWidth /35),
		   (Screen.height / 1.2f) - (buttonWidth / 20),
		    buttonWidth, buttonHeigth), "JOGAR"))
		{
			Application.LoadLevel("Bheta");	
		}
		
		
	}
}
