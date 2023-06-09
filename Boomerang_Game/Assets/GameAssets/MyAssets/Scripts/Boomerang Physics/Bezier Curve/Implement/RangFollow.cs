using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangFollow : MonoBehaviour
{
    public RangPhysics curve;
    public CheckHand checkHand;
    public float speed;
    private float sampleTime;
    // private bool isMagnitude = true;

    void Start(){
        sampleTime =0f;
    }

    public void toggleScript(){
        sampleTime = 0f;
        // isMagnitude = !isMagnitude;
        toggleRayCurve();
        gameObject.GetComponent<RangFollow>().enabled = !gameObject.GetComponent<RangFollow>().enabled;
    }

    public void toggleRayCurve(){
        curve.GetComponent<LineRenderer>().enabled = false;
    }

    void Update()
    {
        // if(isMagnitude){
        //     speed = checkHand.Magnitude;
        //     isMagnitude = !isMagnitude;
        // }

        sampleTime += Time.deltaTime*speed;
        transform.position = curve.evaulate(sampleTime);
        transform.forward = curve.evaulate(sampleTime + 0.001f) - transform.position;
        
        if(sampleTime >= 0.8f){
            toggleRayCurve();
        }
        // Debug.Log(curve.evaulate(sampleTime + 0.001f));
        if(sampleTime >= 1f){
            toggleScript();
        }
    }

}
