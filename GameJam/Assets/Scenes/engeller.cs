using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class engeller : MonoBehaviour
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
        SceneManager.LoadScene(0);
    }
}
