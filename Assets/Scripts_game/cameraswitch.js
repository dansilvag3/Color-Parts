#pragma strict

var cam1 : Camera;
var cam2 : Camera;

function Start () {
	
	cam1.camera.enabled = true;
	cam2.camera.enabled = false;
	yield WaitForSeconds (12);
	cam1.camera.enabled = false;
	cam2.camera.enabled = true;
	

}