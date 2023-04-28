using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPointsActive : MonoBehaviour
{

    public Transform hand;
    public Transform A;
    public Transform B;
    public RayCast rayCast;
    Vector3 rayPosition;

    // Update is called once per frame
    void Update()
    {
        rayPosition = rayCast.fireRay();
        A.position = hand.position;
        B.position = rayPosition;
    }
}
