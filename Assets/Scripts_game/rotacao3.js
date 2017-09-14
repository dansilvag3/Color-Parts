#pragma strict

var VelRot: float;

function Start () {

}

function Update () {

transform.Rotate(0,0,VelRot*Time.deltaTime);

}