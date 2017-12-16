using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class FireLaser : MonoBehaviour ,IInputClickHandler{

    public GameObject holeInWall;

    public GameObject LaserPrefab;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("click event captured inside spatial mapping, laser started ");

        Instantiate(LaserPrefab);
        
        
        StartCoroutine(waitSeconds(0.6f));





    }



    IEnumerator waitSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Instantiate(holeInWall, GazeManager.Instance.HitInfo.point,
            Quaternion.FromToRotation(Vector3.up, GazeManager.Instance.HitInfo.normal));
    }
}
