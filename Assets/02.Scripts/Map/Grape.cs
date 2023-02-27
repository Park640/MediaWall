using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grape : MonoBehaviour
{
    public GameObject grapeFruit;
<<<<<<< HEAD
    public GameObject grapeNeon;
=======
>>>>>>> 576edfe6 (Initial commit)
    private void OnMouseDown()
    {
        grapeFruit.SetActive(false);
        grapeFruit.SetActive(true);
        grapeFruit.GetComponent<Animator>().enabled = true;
<<<<<<< HEAD
        grapeNeon.SetActive(true);
        Invoke("neonDestory", 1f);
=======
>>>>>>> 576edfe6 (Initial commit)
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grapeFruit.SetActive(false);
        grapeFruit.SetActive(true);
        grapeFruit.GetComponent<Animator>().enabled = true;
<<<<<<< HEAD
        grapeNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    void neonDestory()
    {
        grapeNeon.SetActive(false);
=======
>>>>>>> 576edfe6 (Initial commit)
    }
}
