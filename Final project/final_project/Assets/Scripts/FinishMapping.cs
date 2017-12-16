using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class FinishMapping : MonoBehaviour, ISpeechHandler
{
    public delegate void MappingEvent();
    public static event MappingEvent OnFinished;

    
    
    public SpatialUnderstandingCustomMesh spatialUnderstandMesh;
    

    public void OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        switch (eventData.RecognizedText.ToLower())
        {
            case "finish mapping":
                Debug.Log("finish mapping command received");
                
                SpatialUnderstanding.Instance.RequestFinishScan();

                spatialUnderstandMesh.DrawProcessedMesh = false;
                
                
//                gameObject.SendMessage("OnFinishedMapping");
                if (OnFinished != null)
                {
                    Debug.Log("Invoking OnFinished for finished spatial mapping");
                    OnFinished();
                }
                
                
                break;

            default:
                Debug.Log("unknown keyword command received");
                break;
        }
    }
}
