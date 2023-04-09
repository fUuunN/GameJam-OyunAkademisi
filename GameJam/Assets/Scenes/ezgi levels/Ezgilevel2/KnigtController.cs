using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class KnigtController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    float hareket;
    public Animator anim;
    private bool karaktersagyon = true;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
    }

    
    void Update()
    {
        hareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(hareket * speed, rb.velocity.y);

        if (hareket !=0)
        {
            anim.SetBool("isRunning", true);
        }
        else if (hareket == 0)
        {
            anim.SetBool("isRunning", false);
        }

        if( karaktersagyon == false && hareket>0)
        {
            Flip();
        } else if (karaktersagyon == true && hareket<0)
        {
            Flip();
        }


    }

    private void Flip()
    {
        karaktersagyon = !karaktersagyon;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }



}
