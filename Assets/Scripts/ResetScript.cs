using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{
    // we will create Reset Function and use the variables to
    // store original position and rotation
    Vector3 startPosition;
    Quaternion startRotation;

    // by resetting the position we are teleporting the objects to initial position
    // we need to capture how that object is in motion
    // transform, character controller and rigidbody
    // can be used for bringing it into motion

    // in case of charaacter controller and rigidbody
    // we need to disable the method by which it came into motion
    // by disabling rigidbody we mean the following
    // we disable the forces acting on it - making it kinematic body
    // this is done by turning on the kinematic bool

    // then we will reset the position and rotation
    // its important to enable iskinematic before resetting the 
    // position and rotation
    // after resetting the position and rotation turning iskinematic
    // on again is based on necessity
    bool isKinematicInitial;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
        isKinematicInitial = rb.isKinematic;
    }

    public void Reset()
    {
        rb.isKinematic = true;
        transform.position = startPosition;
        transform.rotation = startRotation;
        rb.isKinematic = isKinematicInitial;
    }

    // Update is called once per frame
    // void Update()
    // {}
}
