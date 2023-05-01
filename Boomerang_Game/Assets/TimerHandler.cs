using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerHandler : MonoBehaviour
{
    public float timeDuration = 1f * 60f;
    public bool timerOn = false;

    // Update is called once per frame
    void Update()
    {
        timeDuration -= Time.deltaTime;
        // Debug.Log(timeDuration);
    }
}
