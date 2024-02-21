using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            Debug.LogWarning("you win");
            Debug.LogWarning(SceneManager.GetActiveScene().buildIndex);
            Debug.LogWarning(SceneManager.GetActiveScene().buildIndex + 1);
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                SceneManager.LoadScene("level2");
            }
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                SceneManager.LoadScene("Main Menu");
            }
        }
    }
}
