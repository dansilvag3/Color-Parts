using UnityEngine;
using System.Collections;
 
public class Mover_obj : MonoBehaviour {
    float distance = 5;
    void OnMouseDrag(){
        Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
        transform.position = objPosition;
    }
}
