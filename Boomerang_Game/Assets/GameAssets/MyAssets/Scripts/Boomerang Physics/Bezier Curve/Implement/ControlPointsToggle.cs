using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPointsToggle : MonoBehaviour
{
    public ControlPointsActive cpa;
    public ControlPointsSet cps;

    public void toggleCPA(){
        cpa.enabled = !cpa.enabled;
    }

    public void toggleCPS(){
        cps.enabled = !cps.enabled;
    }

}
