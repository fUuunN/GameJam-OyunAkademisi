using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    bool canDash = true;
    bool isDashing;
    public float dashingTime;
    public float dashingPower;
    public float dashingCooldown;
    public Rigidbody2D dashRb;
    // Update is called once per frame
    void Update()
    {
        if (isDashing)
        {
            return;
        }
        if (canDash && Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(Dashh());
        }
    }

    private void FixedUpdate()
    {
        if (isDashing) { return; }
    }
    IEnumerator Dashh()
    {
        canDash = false;
        isDashing = true;
        float gravity = dashRb.gravityScale;
        dashRb.gravityScale = 0f;
        dashRb.velocity = new Vector2(transform.localScale.x * dashingPower * Time.deltaTime, 0f);
        yield return new WaitForSeconds(dashingTime);
        dashRb.gravityScale = gravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
}
