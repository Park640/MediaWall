using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToIntro : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Intro");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SceneManager.LoadScene("Intro");
    }
}
