using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheat : MonoBehaviour
{
    public GameObject wheat;

    private void OnMouseDown()
    {
        wheat.SetActive(false);
        wheat.SetActive(true);
        wheat.GetComponent<Animator>().enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        wheat.SetActive(false);
        wheat.SetActive(true);
        wheat.GetComponent<Animator>().enabled = true;
    }
}
