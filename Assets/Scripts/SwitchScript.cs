using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{

    public bool isOn = false;
    public SpriteRenderer spriterend;
    public Sprite newSprite1;
    public Sprite newSprite2;

    void Update ()
    {
        if (isOn)
        {
            spriterend.sprite = newSprite1;
        }
        else
        {
            spriterend.sprite = newSprite2;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("Player"))
        {
            isOn = !isOn;
        }
    }
}
