using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{

    public bool isOn = false;

    private void Start()
    {
        Debug.LogWarning("Start");
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.LogWarning("Something");

        if (col.gameObject.CompareTag("Player"))
        {
            isOn = !isOn;
            Debug.LogWarning("Something entered");
        }
    }
}
