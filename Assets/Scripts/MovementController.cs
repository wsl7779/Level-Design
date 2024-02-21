using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private bool clockwise = false;
    private bool isJumping = false;
    private float jumpHeight = 10f;
    private float angle = 0f;
    private float moveSpeed = 6f;

    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(angle);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Corner")) {
            Debug.Log(angle);
            isJumping = false;
            if (clockwise) {
                if (angle != 270) {
                    angle += 90;
                }
                else {
                    angle = 0;
                }
            }
            else {
                if (angle != 0) {
                    angle -= 90;
                }
                else {
                    angle = 270;
                }
            }
        }
        if(other.gameObject.CompareTag("Rail")) {
            Debug.Log("Rail contact");
            isJumping = false;
            //rb.velocity = new Vector2(0, 0);
            if (angle == 0) {
                rb.velocity = new Vector2(-moveSpeed, 0);
                Debug.Log("moving");
            }
            if (angle == 90) {
                rb.velocity = new Vector2(0, -moveSpeed);
                Debug.Log("moving");
            }
            if (angle == 180) {
                rb.velocity = new Vector2(-moveSpeed, 0);
                Debug.Log("moving");
            }
            if (angle == 270) {
                rb.velocity = new Vector2(0, moveSpeed);
                Debug.Log("moving");
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        //jumping
        if (Input.GetKeyDown("space") && isJumping == false)
        {
            isJumping = true;
            clockwise = !clockwise;
            moveSpeed = -moveSpeed;
            Debug.Log("jumping");
            Debug.Log(angle);

            if (angle == 0) {
                rb.velocity = new Vector2(0, -jumpHeight);
                angle = 180f;
            }
            if (angle == 90) {
                rb.velocity = new Vector2(10, 0);
                angle = 270f;
            }
            if (angle == 180) {
                rb.velocity = new Vector2(0, -jumpHeight);
                angle = 0f;
            }
            if (angle == 270) {
                rb.velocity = new Vector2(-jumpHeight, 0);
                angle = 90;
            }
        }
    }
}
