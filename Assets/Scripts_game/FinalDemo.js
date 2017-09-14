#pragma strict

var tempo: float;

function Start () {

guiTexture.pixelInset.width = Screen.width;
guiTexture.pixelInset.x     = -guiTexture.pixelInset.width/2;

guiTexture.pixelInset.height = Screen.height*2;
guiTexture.pixelInset.y      = -guiTexture.pixelInset.height-guiTexture.pixelInset.height/2;

}

function Update () {

guiTexture.pixelInset.y += Screen.height/tempo * Time.deltaTime;

}