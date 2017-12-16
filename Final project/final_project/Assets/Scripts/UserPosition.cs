using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class UserPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	    Debug.Log("Position: " + Camera.main.transform.position);
	    
	    Debug.Log("Rotation: \n");
	    Debug.Log(Camera.main.transform.rotation);
	    
		
	}
}
