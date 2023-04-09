using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaticEnemies : MonoBehaviour
{
    int score;
    private void Awake()
    {
        score = Collectibles.score;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("D��man");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Collectibles.score = score;
        }
    }
}
