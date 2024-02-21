using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RailMover : MonoBehaviour
{
    Vector3 endpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.GetComponent<Rigidbody2D>().velocity = gameObject.transform.rotation * new Vector3(5, 0, 0);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        endpoint = collision.transform.position;
        if (collision.transform.tag == "Player" && Input.GetButtonDown("Jump"))
        {
            collision.transform.GetComponent<Rigidbody2D>().velocity = gameObject.transform.rotation * new Vector3(0, 1, 0);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag != "Player") { return; }
        if (Input.GetButtonDown("Jump"))
        {
            collision.transform.GetComponent<Rigidbody2D>().velocity = gameObject.transform.rotation * new Vector3(0, 2.5f, 0);
        } else
        {
            collision.transform.position = endpoint;
            collision.transform.GetComponent<Rigidbody2D>().velocity = gameObject.transform.rotation * new Vector3(0, 5, 0);
        }
    }
}
