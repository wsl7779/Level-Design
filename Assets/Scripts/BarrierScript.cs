using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{

    public bool active = true;
    public bool barrierA = true;
    public Transform player;
    public SwitchScript switchScript;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<MovementController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (barrierA)
        {
            CheckSwitchA();
        }
        else
        {
            CheckSwitchB();
        }
        ToggleActive();
    }

    void ToggleActive()
    {
        if (active)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player.GetComponent<Collider2D>(), false);
        }
        else
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), player.GetComponent<Collider2D>(), true);
        }
    }

    void CheckSwitchA()
    {
        if (switchScript.isOn) {
            active = true;
        }
        else
        {
            active = false;
        }
    }

    void CheckSwitchB()
    {
        if (!switchScript.isOn)
        {
            active = true;
        }
        else
        {
            active = false;
        }
    }
}
