using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextMovement : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    bool facing;
    float movementInputs = 0;
    SpriteRenderer spriteRenderer;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = rb.GetComponent<SpriteRenderer>();
        animator = rb.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInputs = Input.GetAxisRaw("Horizontal");

        if(movementInputs < 0)
        {
            facing = true;
            spriteRenderer.flipX = facing;
        }
        else if(movementInputs > 0 )
        {
            facing = false;
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = facing;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movementInputs * speed, rb.velocity.y);
        animator.SetFloat("Speed",Mathf.Abs(movementInputs * speed));
    }
}
