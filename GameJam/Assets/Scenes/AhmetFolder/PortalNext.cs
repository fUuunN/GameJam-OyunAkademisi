using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PortalNext : MonoBehaviour
{
    public bool opened;
    public bool close;
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(portalOpen());
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collider içi");
        if (col.CompareTag("Player"))
        {
            close = true;
            animator.SetBool("Close",close);
            StartCoroutine(nextScene());
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    IEnumerator portalOpen()
    {
        yield return new WaitForSeconds(0.5f);
        opened = true;
        animator.SetBool("Opened", opened);
    }

    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(0.75f);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
