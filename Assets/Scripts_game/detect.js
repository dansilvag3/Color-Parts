#pragma strict

var cam4Active : Camera;

function OnTriggerEnter (col : Collider) {
	
	if(col.gameObject.name == "Colizor")
	{
	   Destroy(col.gameObject);
	   GameObject.Find("Camera02").GetComponent(Animation).enabled = true;
	   cam4Active.GetComponent(cameraswitch).enabled = true;	

	}

}