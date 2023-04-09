using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed;
    float hori;
    float verti;
    Rigidbody2D rb;
    float movementInputs = 0;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        movementInputs = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movementInputs * speed, rb.velocity.y);
    }
}
