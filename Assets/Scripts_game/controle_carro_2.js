#pragma strict
var velocidade: float;
var atual: float;

function Start () {

}

function Update () {

atual = rigidbody.velocity.magnitude;

if (atual < 10)
velocidade= 0.8;
if (atual > 11 && atual <41)
velocidade= 1.2;
if (atual > 42 && atual <62)
velocidade= 2;
if (atual > 63)
velocidade= 2.5;

rigidbody.velocity += transform.right*velocidade*Input.GetAxis("Vertical");

if (atual > 0)
  { 
 transform.Rotate(0,Input.GetAxis("Horizontal")*50*Time.deltaTime,0);
 if (Input.GetAxis("Horizontal")!=0)
  {
   rigidbody.drag=1.2;
  }
else
  {
   rigidbody.drag=1;
  }
}

if (Input.GetKey(KeyCode.Space))
{
rigidbody.drag = 6;
}

if (Input.GetKeyUp(KeyCode.Space))
{
rigidbody.drag = 1;
}

}