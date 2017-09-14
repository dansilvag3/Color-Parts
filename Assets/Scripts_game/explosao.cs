using UnityEngine;
using System.Collections;

public class explosao : MonoBehaviour {
	
	public GameObject explosionPrefab;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col)
	{
		Debug.Log("EXPLODE");
		explosionPrefab.SetActiveRecursively(true);
	}
}

