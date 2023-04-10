using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Animator anim;
    public int maxHealth = 100;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void takeDamage(int damage)
    {
        currentHealth-=damage;
        anim.SetTrigger("EnemyHurt");
        if (currentHealth<=0)
        {
            Die();
        }
    }
    void Die()
    {
        anim.SetBool("EnemyDied", true);
        this.enabled=false;
        GetComponent<Collider2D>().enabled = false;
        Destroy(gameObject, 2f);
    }

}
