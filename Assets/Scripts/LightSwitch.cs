using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    Light light;
    

    // Use this for initialization
    void Start()
    {
        light = GetComponent<Light>();
      
    }

    // Update is called once per frame
    void Update()
    {
        light.enabled = true;
    }
}
