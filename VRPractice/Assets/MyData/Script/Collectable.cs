using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 spin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spin = new Vector3(5f, 5f, 0f);
        transform.Rotate(spin);
        
    }
}
