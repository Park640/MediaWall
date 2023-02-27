using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeShip : MonoBehaviour
{
    public GameObject orangeShip;

    private void OnMouseDown()
    {
        orangeShip.SetActive(false);
        orangeShip.SetActive(true);
        orangeShip.GetComponent<Animator>().enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        orangeShip.SetActive(false);
        orangeShip.SetActive(true);
        orangeShip.GetComponent<Animator>().enabled = true;
    }

}
