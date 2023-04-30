using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBox : MonoBehaviour
{
    public GameObject prefab;
    public float timeBetweenSpawn;
    private float elapsedTime = 0;

    void Update(){
        elapsedTime += Time.deltaTime;

        if(elapsedTime > timeBetweenSpawn){
            elapsedTime = 0;
            
            Vector3 random = Random.insideUnitSphere * 8.5f;

            while(random.y <= 0){
                random = Random.insideUnitSphere * 8.5f;
            }
            Instantiate(prefab, random, Quaternion.identity);
        }
    }
}
