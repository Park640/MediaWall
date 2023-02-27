using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiwi : MonoBehaviour
{
    public GameObject kiwiFruit;
<<<<<<< HEAD
    public GameObject kiwiNeon;
=======
>>>>>>> 576edfe6 (Initial commit)
    private void OnMouseDown()
    {
        kiwiFruit.SetActive(false);
        kiwiFruit.SetActive(true);
        kiwiFruit.GetComponent<Animator>().enabled = true;
<<<<<<< HEAD
        kiwiNeon.SetActive(true);
        Invoke("neonDestory", 1f);
=======
>>>>>>> 576edfe6 (Initial commit)
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        kiwiFruit.SetActive(false);
        kiwiFruit.SetActive(true);
        kiwiFruit.GetComponent<Animator>().enabled = true;
<<<<<<< HEAD
        kiwiNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    void neonDestory()
    {
        kiwiNeon.SetActive(false);
=======
>>>>>>> 576edfe6 (Initial commit)
    }
}
