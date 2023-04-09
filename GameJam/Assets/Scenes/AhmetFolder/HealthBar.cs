using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject greenBar;
    private float health=0;
    // Start is called before the first frame update
    void Start()
    {
        health = (Collectibles.score)*10;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
