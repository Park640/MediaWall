using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheat : MonoBehaviour
{
    public GameObject wheat;
<<<<<<< HEAD
    public GameObject wheatNeon;
=======
>>>>>>> 576edfe6 (Initial commit)

    private void OnMouseDown()
    {
        wheat.SetActive(false);
        wheat.SetActive(true);
        wheat.GetComponent<Animator>().enabled = true;
<<<<<<< HEAD
        wheatNeon.SetActive(true);
        Invoke("neonDestory", 1f);
=======
>>>>>>> 576edfe6 (Initial commit)
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        wheat.SetActive(false);
        wheat.SetActive(true);
        wheat.GetComponent<Animator>().enabled = true;
<<<<<<< HEAD
        wheatNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }
    void neonDestory()
    {
        wheatNeon.SetActive(false);
    }
}
=======
    }
}
>>>>>>> 576edfe6 (Initial commit)
