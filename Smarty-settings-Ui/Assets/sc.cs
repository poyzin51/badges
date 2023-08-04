using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class sc : MonoBehaviour
{
    public GameObject myOb;
    public ARRaycastManager raycastManager;
    
    
    void Update()
    {if(Input.touchCount>0 && Input.GetTouch(0).phase==TouchPhase.Began)
        { List<ARRaycastHit> touches = new List<ARRaycastHit>();
            raycastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

            if(touches.Count>0)
            { GameObject.Instantiate(myOb, touches[0].pose.position, touches[0].pose.rotation);
            }
        }
        
    }
}
