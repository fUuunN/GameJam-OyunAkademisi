using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    GameObject nesne;
    public Vector3 offset = new Vector3(1, 1, 0);
    private void Start()
    {
        nesne = GameObject.FindGameObjectWithTag("Player");
    }

    private void LateUpdate()
    {
        transform.position = nesne.transform.position + offset;
    }
}
