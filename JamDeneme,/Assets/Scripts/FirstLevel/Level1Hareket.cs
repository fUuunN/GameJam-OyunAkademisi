using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Level1Hareket : MonoBehaviour
{
    float horizontal;
    float vertical;
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        transform.Translate(horizontal * Time.fixedDeltaTime * speed , vertical * Time.fixedDeltaTime * speed , transform.position.z);    
    }
}
