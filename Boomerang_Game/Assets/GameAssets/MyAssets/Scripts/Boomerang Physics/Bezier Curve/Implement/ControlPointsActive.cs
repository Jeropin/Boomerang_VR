using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPointsActive : MonoBehaviour
{

    public Transform hand;
    public Transform A;
    public Transform B;
    public Transform Control;
    public RayCast rayCast;
    Vector3 rayPosition;

    // Update is called once per frame
    void Update()
    {
        rayPosition = rayCast.fireRay();
        A.position = hand.position;
        B.position = rayPosition;
        Control.position = B.position - A.position;

        // Debug.Log("A Pos: " + A.position);
        // Debug.Log("B Pos: " + B.position);
        // Debug.Log("Control Pos: " + Control.position);
    }
}
