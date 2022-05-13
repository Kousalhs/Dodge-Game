using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer myRenderer;
    Rigidbody myRigidBody;
    [SerializeField] float timeToWait = 3f;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);

        if (Time.time > timeToWait)
        {
            //Debug.Log(timeToWait + " seconds has elapsed");

            myRenderer.enabled = true;
            myRigidBody.useGravity = true;
        }
    }
}
