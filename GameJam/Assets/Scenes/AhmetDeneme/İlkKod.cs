using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class İlkKod : MonoBehaviour
{
    public float speed;
    float horizontalInput;
    float verticalInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        transform.Translate(horizontalInput * speed * Time.fixedDeltaTime, verticalInput * speed * Time.fixedDeltaTime, transform.position.z);   
    }
}
