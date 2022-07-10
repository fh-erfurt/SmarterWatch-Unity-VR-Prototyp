using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class VacumScript : MonoBehaviour
{
    public GameObject ObjectToActive;

    void Start()
    {
        ObjectToActive.GetComponent<Animator>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
