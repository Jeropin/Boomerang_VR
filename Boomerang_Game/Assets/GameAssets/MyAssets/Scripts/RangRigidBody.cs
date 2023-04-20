using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// User slerp physics combine with the rigidbody
public class RangRigidBody : MonoBehaviour
{
    private Rigidbody body;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
     body = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity += new Vector3(0.1f, 0.1f, 0);
        // x++;

        Debug.Log(body.velocity);
        // body.velocity = Vector3.left;
        // body.velocity = Vector3.left;
    }
}
