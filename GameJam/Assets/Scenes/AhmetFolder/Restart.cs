using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour


{
  


    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collider i�i");
        if (col.CompareTag("Player"))
        {
            Debug.Log("�f   i�i");
            ResLevel();
        }
    }
    public void ResLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
