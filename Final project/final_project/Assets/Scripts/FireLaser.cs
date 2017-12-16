using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class FireLaser : MonoBehaviour ,IInputClickHandler{

    public GameObject holeInWall;

    public GameObject LaserPrefab;

    
    private bool map_finished = false;

    
    void Start()
    {
        FinishMapping.OnFinished += FinishMapping_OnFinished        ;
    }

    private void FinishMapping_OnFinished()
    {
        Debug.Log("FireLaser recieved OnFinishedMapping");
        map_finished = true;
    }
    
    public void OnInputClicked(InputClickedEventData eventData)
    {

        if (map_finished == true)
        {
            Debug.Log("click event captured inside spatial mapping, finished mapping so firing laser ");

            Instantiate(LaserPrefab);


            StartCoroutine(waitSeconds(0.6f));


        }
        else
        {
            Debug.Log("click event captured inside spatial mapping, but still mapping ");
        }



    }



    IEnumerator waitSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Instantiate(holeInWall, GazeManager.Instance.HitInfo.point,
            Quaternion.FromToRotation(Vector3.up, GazeManager.Instance.HitInfo.normal));
    }
}
