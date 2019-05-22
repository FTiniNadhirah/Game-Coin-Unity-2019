using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canGrab = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("I can grab");
            canGrab = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        Debug.Log("I can't grab");
        canGrab = false;
        
    }
}
