using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public Ray ray;

    public Vector3 fireRay(){
        ray = new Ray(transform.position, transform.forward * 500);
        // Debug.Log(ray);
        RaycastHit hitData;
        // Debug.Log(hit.point);
        Physics.Raycast(ray, out hitData);
        // Debug.Log(hitData.point);
        return hitData.point;
    }
    void Update()
    {
        // ray = new Ray(transform.position, transform.forward * 500);
        Debug.DrawRay(transform.position, transform.forward * 500, Color.red);
    }
}
