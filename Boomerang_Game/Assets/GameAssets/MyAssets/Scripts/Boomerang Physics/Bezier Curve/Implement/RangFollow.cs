using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Boomerang Object following the curve created
public class RangFollow : MonoBehaviour
{
    public RangPhysics curve;
    public ControlPointsSet setReturn;
    public float speed;
    private float sampleTime;
    void Start(){
        sampleTime =0f;
    }

    public void toggleScript(){
        sampleTime = 0f;
        gameObject.GetComponent<RangFollow>().enabled = !gameObject.GetComponent<RangFollow>().enabled;
    }

    void Update()
    {
        sampleTime += Time.deltaTime*speed;
        transform.position = curve.evaulate(sampleTime);
        transform.forward = curve.evaulate(sampleTime + 0.001f) - transform.position;
        
        // Debug.Log(curve.evaulate(sampleTime + 0.001f));

        // Debug.Log(sampleTime);
        if(sampleTime >= 1f){
            toggleScript();
        }
    }

}
