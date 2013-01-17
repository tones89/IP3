using UnityEngine;
using System.Collections;

public class Cube_move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate(0,5*Time.deltaTime,0);
		
	}
}
