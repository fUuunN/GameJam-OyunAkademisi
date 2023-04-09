using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image greenBar;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = (float)(Collectibles.score)*10;   
    }

    // Update is called once per frame
    void Update()
    {
        greenBar.rectTransform.localScale = new Vector3(health / 100f, 1f, 1f);
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
