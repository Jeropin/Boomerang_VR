using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ToggleColor : MonoBehaviour
{
    public InputActionProperty changeColorButton;
    public GameObject disk;
    public Material color1;
    public Material color2;
    
    // Start is called before the first frame update

    void Update()
    {
        Debug.Log(changeColorButton.action.ReadValue<float>());

        if(changeColorButton.action.ReadValue<float>() == 1){
            ChangeColor();
        }
    }
    void ChangeColor()
    {
        if(disk.GetComponent<Renderer>().material = color1){
            disk.GetComponent<Renderer>().material = color2;
        }
        else{
            disk.GetComponent<Renderer>().material = color1;
        }

    }
}
