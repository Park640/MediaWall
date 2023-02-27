using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeShip : MonoBehaviour
{
    public GameObject orangeShip;
<<<<<<< HEAD
    public GameObject orangeNeon;
=======

>>>>>>> 576edfe6 (Initial commit)
    private void OnMouseDown()
    {
        orangeShip.SetActive(false);
        orangeShip.SetActive(true);
        orangeShip.GetComponent<Animator>().enabled = true;
<<<<<<< HEAD
        orangeNeon.SetActive(true);
        Invoke("neonDestory", 1f);
=======
>>>>>>> 576edfe6 (Initial commit)
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        orangeShip.SetActive(false);
        orangeShip.SetActive(true);
        orangeShip.GetComponent<Animator>().enabled = true;
<<<<<<< HEAD
        orangeNeon.SetActive(true);
        Invoke("neonDestory", 1f);
    }

    void neonDestory()
    {
        orangeNeon.SetActive(false);
    }
=======
    }

>>>>>>> 576edfe6 (Initial commit)
}
