using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangPhysics : MonoBehaviour
{

    public Transform A;
    public Transform B;
    public Transform Control;
    public LineRenderer lineRend;

    private Vector3[] positions = new Vector3[20];

    void Start(){
        // lineRend = gameObject.AddComponent<LineRenderer>();
        lineRend.material = new Material(Shader.Find("Legacy Shaders/Particles/Alpha Blended Premultiply"));
        lineRend.positionCount = 20;
    }
    public Vector3 evaulate(float t){

        // Using last known position of ray and hand
        // Vector3 ac = Vector3.Lerp(lastPosition, Control.position, t);
        // Vector3 cb = Vector3.Lerp(Control.position, rayPosition, t);
        Vector3 ac = Vector3.Lerp(A.position, Control.position, t);
        Vector3 cb = Vector3.Lerp(Control.position, B.position, t);
        return Vector3.Lerp(ac, cb, t);
    }

    private void OnDrawLine(){
        if(A == null || B == null || Control == null){
            return;
        }

        for(int i = 0; i < 20; i++){
            positions[i] = evaulate(i / 20f);
        }

        lineRend.SetPositions(positions);
    }

    private void OnDrawGizmos(){
        if(A == null || B == null || Control == null){
            return;
        }

        Gizmos.color = Color.blue;
        for(int i = 0; i < 20; i++){
            positions[i] = evaulate(i / 20f);
            // Gizmos.DrawWireSphere(evaulate(i / 20f), 0.1f);

        }
        lineRend.SetPositions(positions);
        // Debug.Log(positions);
    }
}
