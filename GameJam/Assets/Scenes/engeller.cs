using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class engeller : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collider içi");
        if (col.CompareTag("Player"))
        {
            Debug.Log("Ýf   içi");
            ResLevel();
        }
    }
    public void ResLevel()
    {
        SceneManager.LoadScene(0);
    }
}
