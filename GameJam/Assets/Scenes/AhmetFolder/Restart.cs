using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    int score;
    private void Awake()
    {
        score = Collectibles.score;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collider i�i");
        if (col.CompareTag("Player"))
        {
            Collectibles.score = score;
            Debug.Log("�f   i�i");
            ResLevel();
        }
    }
    public void ResLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
