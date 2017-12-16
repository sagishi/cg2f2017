using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class hideInfo : MonoBehaviour,IInputClickHandler {

	// Use this for initialization
	void Start () {
		Destroy(gameObject,5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnInputClicked(InputClickedEventData eventData)
    {
        this.gameObject.SetActive(false);
    }
}
