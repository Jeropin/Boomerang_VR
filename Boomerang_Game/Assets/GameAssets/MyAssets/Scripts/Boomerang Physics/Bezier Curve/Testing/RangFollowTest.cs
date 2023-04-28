using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangFollowTest : MonoBehaviour
{
    public RangPhysicsTest curve;
    public float speed;
    private float sampleTime;
    void Start(){
        sampleTime =0f;
    }
    void Update()
    {
        sampleTime += Time.deltaTime*speed;
        transform.position = curve.evaulate(sampleTime);
        transform.forward = curve.evaulate(sampleTime + 0.001f) - transform.position;
        
    }
}
