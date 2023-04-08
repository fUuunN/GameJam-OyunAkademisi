using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Level2Karakte : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;

    float movementInputs = 0;
    [SerializeField] float speed;
    [SerializeField] float jumpingPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementInputs = Input.GetAxisRaw("Horizontal");
        if(Input.GetButtonDown("Jump") && IsGrounded()) 
        {
            rb.velocity = new Vector2 (rb.velocity.x, jumpingPower );
            
        }

        if(Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            //rb.gravityScale = 10f;
        }
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.3f, groundLayer);
    }

    void FixedUpdate()
    {
        rb.velocity=new Vector2 (movementInputs * speed, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ground"))
        {
            rb.gravityScale = 1f;
        }
    }
    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ground"))
        {
            rb.gravityScale = 10f;
        }
    }
}
