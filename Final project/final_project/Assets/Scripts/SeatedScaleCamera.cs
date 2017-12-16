using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class SeatedScaleCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    XRDevice.SetTrackingSpaceType(TrackingSpaceType.Stationary);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
