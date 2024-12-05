using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class AxleInfo2
{
    public WheelCollider leftWheel2;
    public WheelCollider rightWheel2;
    public bool motor2;
    public bool steering2;
}

public class CarControl2 : MonoBehaviour
{
    public List<AxleInfo2> axleInfos2;
    public float maxMotorTorque2;
    public float maxSteeringAngle2;

    // finds the corresponding visual wheel
    // correctly applies the transform
    public void ApplyLocalPositionToVisuals(WheelCollider collider)
    {
        if (collider.transform.childCount == 0)
        {
            return;
        }

        Transform visualWheel = collider.transform.GetChild(0);

        Vector3 position;
        Quaternion rotation;
        collider.GetWorldPose(out position, out rotation);

        visualWheel.transform.position = position;
        visualWheel.transform.rotation = rotation;
    }

    public void FixedUpdate()
    {
        float motor = maxMotorTorque2 * Input.GetAxis("Vertical2");
        float steering = maxSteeringAngle2 * Input.GetAxis("Horizontal2");

        foreach (AxleInfo2 axleInfo2 in axleInfos2)
        {
            if (axleInfo2.steering2)
            {
                axleInfo2.leftWheel2.steerAngle = steering;
                axleInfo2.rightWheel2.steerAngle = steering;
            }
            if (axleInfo2.motor2)
            {
                axleInfo2.leftWheel2.motorTorque = motor;
                axleInfo2.rightWheel2.motorTorque = motor;
            }
            ApplyLocalPositionToVisuals(axleInfo2.leftWheel2);
            ApplyLocalPositionToVisuals(axleInfo2.rightWheel2);
        }
    }
}