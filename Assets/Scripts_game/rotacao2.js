#pragma strict

var VelRot: float;

function Start () {

}

function Update () {

transform.Rotate(VelRot*Time.deltaTime,0,0);

}