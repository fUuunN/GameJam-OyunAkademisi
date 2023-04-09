using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAttack : MonoBehaviour
{
    private bool attack;
    public float attackTimer;
    private float attackCooldown;
    public Collider2D attackCollider;
   
    public Animator anim;
  
 
    void Start()
    {
        attack = false;
        attackCollider.enabled = false;
    }

  
    void Update()
    {
        
    }

    private void Attack()
    {
        if(Input.GetKeyDown(KeyCode.Z) && !attack)
        {
            attack = true;
            attackCollider.enabled = true;
            attackTimer = attackCooldown;
            anim.SetTrigger("attack");
        }

        if (attack)
        {
            if(attackTimer>0)
            {
                attackTimer -= Time.deltaTime;
            }
        }
        else
        {
            attack = false;
        }

    }




}
