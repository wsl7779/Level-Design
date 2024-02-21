using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLevel2Movement : MonoBehaviour
{

    public float angle = 0f;
    private float moveSpeed = 6f;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Corner"))
        {
            Debug.Log(angle);
            if (angle != 0)
            {
                Debug.Log("reach");
                angle -= 90;
            }
            else
            {
                angle = 270;
            }
        }
        else if (other.gameObject.CompareTag("Rail"))
        {
            Debug.Log("Rail contact");
            //rb.velocity = new Vector2(0, 0);
            if (angle == 0)
            {
                rb.velocity = new Vector2(moveSpeed, 0);
                Debug.Log("moving right");
            }
            else if (angle == 90)
            {
                rb.velocity = new Vector2(0, -moveSpeed);
                Debug.Log("moving down");
            }
            else if (angle == 180)
            {
                rb.velocity = new Vector2(-moveSpeed, 0);
                Debug.Log("moving left");
            }
            else if (angle == 270)
            {
                rb.velocity = new Vector2(0, moveSpeed);
                Debug.Log("moving up");
            }
        }
    }
}
