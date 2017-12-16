using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class spatialClick : MonoBehaviour, IInputClickHandler
{

	

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("click event captured inside spatial components");
    }
}
