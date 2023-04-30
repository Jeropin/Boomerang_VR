using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPointsSet : MonoBehaviour
{

    public Transform A;
    public Transform B;
    public RayCast rayCast;
    public Vector3 lastPosition;
    Vector3 rayPosition;
    public void setRayPosition(){
        rayPosition = rayCast.fireRay();
    }

    public void setLastPosition(){
        lastPosition = A.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
