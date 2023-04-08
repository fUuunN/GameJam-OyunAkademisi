using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Level1Hareket : MonoBehaviour
{
    float horizontal;
    float vertical;
    [SerializeField] float speed;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    
    void ChangeSprite(Sprite spriteChange)
    {
        spriteRenderer.sprite = spriteChange; 
    }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        transform.Translate(horizontal * Time.fixedDeltaTime * speed , vertical * Time.fixedDeltaTime * speed , transform.position.z);    
    }
    
           
    void OnCollisionEnter2D(Collision2D donus)
    {
         if (donus.gameObject.CompareTag("Donus"))
        {
           Debug.Log("carptin");
           ChangeSprite(newSprite);
        } 
    } 
}
