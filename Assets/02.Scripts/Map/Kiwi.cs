using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiwi : MonoBehaviour
{
    public GameObject kiwiFruit;
    private void OnMouseDown()
    {
        kiwiFruit.SetActive(false);
        kiwiFruit.SetActive(true);
        kiwiFruit.GetComponent<Animator>().enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        kiwiFruit.SetActive(false);
        kiwiFruit.SetActive(true);
        kiwiFruit.GetComponent<Animator>().enabled = true;
    }
}
