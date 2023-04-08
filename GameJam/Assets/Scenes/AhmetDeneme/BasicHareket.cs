using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicHareket : MonoBehaviour
{
    Rigidbody2D rb;
    float movementInputs = 0;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
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
