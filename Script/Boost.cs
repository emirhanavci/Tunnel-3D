using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    void Start()
    {

    }

     
    void Update()
    {

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Robot")
        {

            gameObject.SetActive(false);
        }
    }

}
