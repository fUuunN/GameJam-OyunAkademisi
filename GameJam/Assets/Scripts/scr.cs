using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    public HingeJoint2D hingeJoint;
    public float swingSpeed = 50000f;

    void Update()
    {
        JointMotor2D motor = hingeJoint.motor;
        motor.motorSpeed = swingSpeed * Mathf.Sin(Time.time);
        hingeJoint.motor = motor;
    }
}
