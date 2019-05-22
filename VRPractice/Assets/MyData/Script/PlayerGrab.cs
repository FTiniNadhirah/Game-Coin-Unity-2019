using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public GameObject myHand;
    bool inHands = false;
    public float handPower;
    Collider ballCol;
    Rigidbody ballRb;
    Camera cam;
    void Start()
    {
        ballCol = ball.GetComponent<SphereCollider>();
        ballRb = ball.GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands && myHand.GetComponent<Grab>().canGrab) {
                ballCol.isTrigger = true;
                ball.transform.SetParent(myHand.transform);
                ball.transform.localPosition = new Vector3(0f, -.627f, 0f);
                inHands = true;
                ballRb.velocity = Vector3.zero;
                ballRb.useGravity = false;
            }else if (inHands)
            {
                ballCol.isTrigger = false;
                ballRb.useGravity = true;
                this.GetComponent<PlayerGrab>().enabled = false;
                ball.transform.SetParent(null);
                ballRb.velocity = cam.transform.rotation * Vector3.forward * handPower;
                inHands = false;
            }

        }   
    }
}
