using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class FinishMapping : MonoBehaviour, ISpeechHandler
{

    public Material OccludMaterial;
    public GameObject spatialunderstand;
    

    public void OnSpeechKeywordRecognized(SpeechEventData eventData)
    {
        switch (eventData.RecognizedText.ToLower())
        {
            case "finish mapping":
                Debug.Log("finish mapping command received");
                
                SpatialUnderstanding.Instance.RequestFinishScan();

                SpatialUnderstandingCustomMesh scriptObject =
                    spatialunderstand.GetComponent<SpatialUnderstandingCustomMesh>();
                if (scriptObject != null)
                {
                    scriptObject.DrawProcessedMesh = false;
                    Debug.Log("FinishMapping: found custom mesh and disabled it");
                }
                break;

            default:
                Debug.Log("unknown keyword command received");
                break;
        }
    }
}
