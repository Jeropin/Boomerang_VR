using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBox : MonoBehaviour
{   

    void OnCollisionEnter(Collision collision){
        FindObjectOfType<ScoreCounter>().scoreIncrease();
        Destroy(gameObject);
    }

}
