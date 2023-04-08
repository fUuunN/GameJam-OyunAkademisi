using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed;
    float hori;
    float verti;

    // Update is called once per frame
    void Update()
    {
        hori = Input.GetAxisRaw("Horizontal");
        verti = Input.GetAxisRaw("Vertical");
        transform.Translate(hori * speed * Time.deltaTime, verti * speed * Time.deltaTime, transform.position.z);
    }
}
