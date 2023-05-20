using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBox : MonoBehaviour
{   
    public AudioSource audioData;

    void Awake(){
        audioData = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision){
        FindObjectOfType<ScoreCounter>().scoreIncrease();
        // audioData.Play();
        // gameObject.GetComponent<AudioSource>().Play();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        audioData.PlayOneShot(audioData.clip);
        // Destroy(gameObject);
        Destroy(gameObject, audioData.clip.length);
    }
}
