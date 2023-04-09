using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image greenBar;
    public float health;
    //float bar
    // Start is called before the first frame update
    void Start()
    {
        health = (Collectibles.score)*10;
       // greenBar.transform.scale.x
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D engel)
    {
         if (engel.gameObject.CompareTag("engel"))
        {
           Debug.Log("carptin");
           health-=10;
        } 
    } 
}
