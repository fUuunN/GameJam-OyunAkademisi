using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogSystem : MonoBehaviour
{
    public string[] lines;
    public float textSpeed;
    public TextMeshProUGUI textComponent;

    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialog();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                nextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
    void StartDialog()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    void nextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    IEnumerator TypeLine()
    {
        foreach (char harf in lines[index].ToCharArray())
        {
            textComponent.text += harf;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
