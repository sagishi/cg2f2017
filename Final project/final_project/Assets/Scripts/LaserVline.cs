using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;
using VolumetricLines;

public class LaserVline : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    VolumetricLineBehavior vline = GetComponent<VolumetricLineBehavior>();

	    if (vline != null)
	    {
	        vline.StartPos = Camera.main.transform.position - Vector3.up * (0.12f);
	        vline.EndPos = GazeManager.Instance.HitInfo.point;
	        

	    }
	    else
	    {
	        
	        Debug.Log("LaserVline: VolumetricLineBehavior script object not found");
	    }

	    Destroy(gameObject, 0.8f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
