using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightJump : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody2D rb;
    public Animator anim;

    private bool zemin;
    public Transform Groundcheck;
    public float Radiuscheck;
    public LayerMask zeminNe;
    private int ekstraZiplama;
    public int ekstraZiplamaSayisi;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (zemin == true)
        {
            ekstraZiplama = ekstraZiplamaSayisi;
        }

        if (Input.GetKeyDown(KeyCode.Space)&&ekstraZiplama > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            ekstraZiplama--;
        } 
        else if (Input.GetKeyDown(KeyCode.Space)&& ekstraZiplama == 0 && zemin==true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }


    }




    private void FixedUpdate()
    {
        zemin = Physics2D.OverlapCircle(Groundcheck.position, Radiuscheck, zeminNe);
    }


}
