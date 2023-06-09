using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPointsActive : MonoBehaviour
{

    public CheckHand whichHand;
    private Transform hand;
    public Transform A;
    public Transform B;
    public Transform Control;
    public RayCast rayCastForward;
    public RayCast rayCastAngle;
    Vector3 rayPositionForward;
    Vector3 rayPositionAngle;

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<LineRenderer>().enabled = true;
        // Get ray cast
        rayPositionForward = rayCastForward.fireRay();
        rayPositionAngle = rayCastAngle.fireRay();

        // Transform position
        A.position = whichHand.handPos.position;
        B.position = rayPositionAngle;
        Control.position = rayPositionForward - A.position;

        // Debug.Log("A Pos: " + A.position);
        // Debug.Log("B Pos: " + B.position);
        // Debug.Log("Control Pos: " + Control.position);
    }
}
