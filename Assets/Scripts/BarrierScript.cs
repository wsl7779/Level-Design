using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{

    public bool active = true;
    public bool barrierA = true;
    public Transform player;
    public SwitchScript switchScript;
    public SpriteRenderer opacity;
    GameObject collisionHandler;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<MovementController>().transform;
        collisionHandler = gameObject.transform.Find("CollisionHandler").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (switchScript != null)
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
    }

    void ToggleActive()
    {
        if (active)
        {
            opacity.color = new Color(1f, 1f, 1f, 1f);
            collisionHandler.SetActive(true);

        }
        else
        {
            opacity.color = new Color(1f, 1f, 1f, 0.5f);
            collisionHandler.SetActive(false);
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

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Player") && active)
        {
            //then you lose
        }
    }
}
