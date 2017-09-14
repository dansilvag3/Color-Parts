#pragma strict

var explosion : Transform; //Detonator-Insanity

function Start () {

}
 
function Update () {
}
 
function OnTriggerEnter(colisao:Collider){
   if(colisao.gameObject.tag == "Azul"){
      GameObject.Instantiate(explosion , transform.position, transform.rotation);
      Destroy(gameObject);
      Destroy(colisao.gameObject);
      
        
 
   
   
   
   }
}

