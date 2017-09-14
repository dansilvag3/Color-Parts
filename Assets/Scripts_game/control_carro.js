#pragma strict
//controle do carro

var frente    : float;
var esquerda  : float;
var direita   : float;
var re        : float;

var freio     : float;
var marcha2   :float;

function Start () {

frente       = 30*Time.deltaTime;
esquerda     = 45*Time.deltaTime;
direita      = 45*Time.deltaTime;
re           = 8*Time.deltaTime;

freio        = 15*Time.deltaTime;
marcha2      = 20*Time.deltaTime;
}

function Update () {

if (Input.GetKey(KeyCode.UpArrow))
{
transform.Translate (-frente,0,0);
}

if (Input.GetKey(KeyCode.LeftArrow))
{
transform.Rotate (0,-esquerda,0);
}

if (Input.GetKey(KeyCode.RightArrow))
{
transform.Rotate (0,direita,0);
}

if (Input.GetKey(KeyCode.DownArrow))
{
transform.Translate (re,0,0);
}

if (Input.GetKey(KeyCode.Space))
{
transform.Translate (freio,0,0);
}

}