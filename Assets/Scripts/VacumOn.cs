using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacumOn : MonoBehaviour
{
    public GameObject ObjectToActive;

    void Start()
    {
        ObjectToActive.GetComponent<Animator>().enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        ObjectToActive.GetComponent<Animator>().enabled = true;
    }
}
