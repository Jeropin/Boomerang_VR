using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RecallRang : MonoBehaviour
{
    public InputActionProperty recallRang;
    public RangFollow rangFollow;
    public Transform transformHand;
    public Transform transformRang;
    public GameObject rang;
    public float speed = 25;
    // private Transform transformHand = Handheld
    // private Transform transformRang = rang.GetComponent<Transform>();


    // Update is called once per frame
    void Update()
    {

        // Debug.Log(recallRang.action.ReadValue<float>());
        if(recallRang.action.ReadValue<float>() == 1){
            Recall();

            if(rangFollow.enabled){
                rangFollow.toggleScript();
            }
        }
        else{
            Rigidbody rigidbody = rang.GetComponent<Rigidbody>();
            rigidbody.isKinematic = false;
            // Add force to rigid body going towards the direction of the hand
            // rigidbody.AddForce(transformHand.position);
            // rang.GetComponent<Rigidbody>().isKinematic = false;
            
        }
    }

    void Recall()
    {
        // Debug.Log("I have been recalled");
        rang.transform.position = Vector3.MoveTowards(rang.transform.position, transformHand.position, 20 * Time.deltaTime);
        rang.GetComponent<Rigidbody>().isKinematic = true;
    }
}
