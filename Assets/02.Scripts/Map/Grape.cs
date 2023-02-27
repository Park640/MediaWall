using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grape : MonoBehaviour
{
    public GameObject grapeFruit;
    private void OnMouseDown()
    {
        grapeFruit.SetActive(false);
        grapeFruit.SetActive(true);
        grapeFruit.GetComponent<Animator>().enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grapeFruit.SetActive(false);
        grapeFruit.SetActive(true);
        grapeFruit.GetComponent<Animator>().enabled = true;
    }
}
