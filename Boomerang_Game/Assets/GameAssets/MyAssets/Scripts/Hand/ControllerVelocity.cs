using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// using UnityEngine.XR;
// using UnityEngine.XR.Interaction.Toolkit;

public class ControllerVelocity : MonoBehaviour
{
    public InputActionProperty velocityProperty;
    public Vector3 Velocity {get; private set; } = Vector3.zero;
    public float Magnitude;

    private void Update(){
        Velocity = velocityProperty.action.ReadValue<Vector3>();
        // Debug.Log(Velocity.x);
        Magnitude = Mathf.Sqrt(Mathf.Pow(Velocity.x, 2) + Mathf.Pow(Velocity.y, 2) + Mathf.Pow(Velocity.z, 2));
        // Debug.Log("Magnitude from hand: " + Magnitude);
        // Debug.Log(Mathf.Sqrt(Mathf.Pow(Velocity.x, 2) + Mathf.Pow(Velocity.y, 2) + Mathf.Pow(Velocity.z, 2)));
    }
}
