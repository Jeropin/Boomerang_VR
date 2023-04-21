using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    // Start is called before the first frame update
    Ray ray;
    RaycastHit hit;
    void Start()
    {
        ray = new Ray(transform.position, transform.forward * 500);
    }

    void CheckForColliders()
    {
        if(Physics.Raycast(ray))
        {
            Debug.Log("Hit");
        }
    }
    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 500, Color.red);
        CheckForColliders();
    }
}
