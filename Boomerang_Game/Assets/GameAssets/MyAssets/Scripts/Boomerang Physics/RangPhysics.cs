using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangPhysics : MonoBehaviour
{
    public GameObject rang;
    public Transform A;
    public Vector3 lastPosition;
    public Transform B;
    public Vector3 rayCastHit;
    public Transform Control;

    void Start(){
        rayCastHit = rang.GetComponent<RayCast>().CheckForColliders();
        Debug.Log(rayCastHit);
    }
    public void setLastPosition(){
        lastPosition = A.position;
    }

    public Vector3 evaulate(float t){
        Vector3 ac = Vector3.Lerp(lastPosition, Control.position, t);
        Vector3 cb = Vector3.Lerp(Control.position, B.position, t);
        return Vector3.Lerp(ac, cb, t);
    }

    private void OnDrawGizmos(){
        if(A == null || B == null || Control == null){
            return;
        }

        Gizmos.color = Color.blue;
        for(int i = 0; i < 20; i++){
            Gizmos.DrawWireSphere(evaulate(i / 20f), 0.1f);
        }
    }
}
