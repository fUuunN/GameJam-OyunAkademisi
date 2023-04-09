using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collectibles : MonoBehaviour
{
    static int score;
    public TMP_Text text;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            score++;
            Debug.Log("Toplandý");
            text.text = "Puan : " + score;
            Destroy(collision.gameObject);
            
        }
    }
}
