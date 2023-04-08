using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObje : MonoBehaviour
{
    [SerializeField] GameObject donusecegiObje;
    [SerializeField] bool donusebilir;
    private void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.CompareTag("Player"))
        {
            donusebilir = true;
            donusecegiObje.transform.position = coll.transform.position;
            Destroy(coll.gameObject);
        }
    }

    void Update()
    {
        if (donusebilir)
        {
            Instantiate(donusecegiObje, donusecegiObje.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
