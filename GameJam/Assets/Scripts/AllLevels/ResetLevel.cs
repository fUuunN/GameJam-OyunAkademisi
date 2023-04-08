using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collider içi");
        if (col.CompareTag("Player"))
        {
            Debug.Log("Ýf   içi");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
