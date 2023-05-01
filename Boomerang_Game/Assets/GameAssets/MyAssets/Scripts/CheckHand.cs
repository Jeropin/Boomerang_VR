using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class CheckHand : MonoBehaviour
{
    public XRDirectInteractor rHand;
    public XRDirectInteractor lHand;

    public InputActionProperty rVelocityProperty;

    public InputActionProperty lVelocityProperty;

    public Vector3 Velocity {get; private set;} = Vector3.zero;

    public float Magnitude;


    void Update()
    {
        // Check for right hand active
        if(rHand.isSelectActive){
            Velocity = rVelocityProperty.action.ReadValue<Vector3>();
            // Debug.Log("RIGHT");
        }
        
        // Check for left hand active
        if(lHand.isSelectActive){
            Velocity = lVelocityProperty.action.ReadValue<Vector3>();
            // Debug.Log("Left");
        }

        // Debug.Log(Velocity);
        Magnitude = Mathf.Sqrt(Mathf.Pow(Velocity.x, 2) + Mathf.Pow(Velocity.y, 2) + Mathf.Pow(Velocity.z, 2));
        // Debug.Log(Magnitude);?
        
        if(Magnitude >= 3f){
            Magnitude = 3;
        }
    }
}
