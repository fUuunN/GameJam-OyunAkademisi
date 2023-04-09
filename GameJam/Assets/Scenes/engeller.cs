using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engeller : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    public float distanceFromTarget = 10f;
    public float minDistanceFromTarget = 5f;
    public float maxDistanceFromTarget = 15f;
    public float heightOffset = 2f;
    public LayerMask layerMask;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;
    }

    void FixedUpdate()
    {
        // Calculate the target position
        Vector3 targetPos = target.position + offset;

        // Calculate the direction from the camera to the target
        Vector3 directionToTarget = targetPos - transform.position;

        // Cast a ray from the target to the camera to check for obstacles
        RaycastHit hitInfo;
        if (Physics.Raycast(targetPos, -directionToTarget.normalized, out hitInfo, maxDistanceFromTarget, layerMask))
        {
            distanceFromTarget = Mathf.Clamp(hitInfo.distance, minDistanceFromTarget, maxDistanceFromTarget);
        }
        else
        {
            distanceFromTarget = maxDistanceFromTarget;
        }

        // Calculate the new camera position
        Vector3 newCamPos = targetPos - directionToTarget.normalized * distanceFromTarget;
        newCamPos.y += heightOffset;

        // Move the camera smoothly to the new position
        transform.position = Vector3.Lerp(transform.position, newCamPos, smoothing * Time.deltaTime);
    }
}
