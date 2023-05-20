using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour
{
    private LineRenderer lineRend;
    private Vector3[] positions;
    RangPhysics curve;
    void Awake(){
        lineRend = gameObject.GetComponent<LineRenderer>();
    }
    
    private void CreateLine(){
        for(int i = 0; i < 20; i++){
            positions[i] = curve.evaulate(i / 20f);
        }

        lineRend.SetPositions(positions);

        // Debug.Log(lineRend);
    }

}
