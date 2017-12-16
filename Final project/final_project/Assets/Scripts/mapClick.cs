using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class mapClick : MonoBehaviour,IInputClickHandler
{

    public GameObject holeInWall;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("click event captured inside spatial mapping ");

        Instantiate(holeInWall, GazeManager.Instance.HitInfo.point,
            Quaternion.FromToRotation(Vector3.up,GazeManager.Instance.HitInfo.normal));
      




    }
}
