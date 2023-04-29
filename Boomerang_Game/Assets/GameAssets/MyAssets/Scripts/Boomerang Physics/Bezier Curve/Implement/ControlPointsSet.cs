using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Curving backwards
public class ControlPointsSet : MonoBehaviour
{

    public Transform A;
    public Transform B;
    public Transform Control;

    // void Start()
    // {
    //     Control.position = new Vector3(Control.position.x * -1, Control.position.y, Control.position.z);
    // }
    // Update is called once per frame
    void Update()
    {
        Control.position = new Vector3(Control.position.x * -1, Control.position.y, Control.position.z);
    }
}
