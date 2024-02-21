using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public bool clockwise = false;
    public bool isJumping = false;
    public float jumpHeight = 10f;
    public float angle = 0f;
    public float moveSpeed = 6f;

    [SerializeField] private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Corner")) {
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
<<<<<<< Updated upstream
        if(other.gameObject.CompareTag("Rail")) {
=======
        else if(other.gameObject.CompareTag("Rail")) {
            Debug.Log("Rail contact");
>>>>>>> Stashed changes
            isJumping = false;
            if (angle == 0) {
<<<<<<< Updated upstream
                rb.velocity = new Vector2(0, moveSpeed);
            }
            if (angle == 90) {
                rb.velocity = new Vector2(moveSpeed, 0);
            }
            if (angle == 180) {
                rb.velocity = new Vector2(0, -moveSpeed);
            }
            if (angle == 270) {
                rb.velocity = new Vector2(-moveSpeed, 0);
=======
                rb.velocity = new Vector2(moveSpeed, 0);
                Debug.Log("should be moving right now");
            }
            else if (angle == 90) {
                rb.velocity = new Vector2(0, -moveSpeed);
                Debug.Log("should be moving down now");
            }
            else if (angle == 180) {
                rb.velocity = new Vector2(-moveSpeed, 0);
                Debug.Log("should be moving left now");
            }
            else if (angle == 270) {
                rb.velocity = new Vector2(0, moveSpeed);
                Debug.Log("should be movingup now");
>>>>>>> Stashed changes
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
            
            if (angle == 0) {
<<<<<<< Updated upstream
                rb.velocity = new Vector2(0, jumpHeight);
                angle = 180f;
            }
            if (angle == 90) {
=======
                Debug.Log("should go up");
                rb.velocity = new Vector2(0, jumpHeight);
                angle = 180f;
            }
            else if (angle == 90) {
                Debug.Log("should go right");
>>>>>>> Stashed changes
                rb.velocity = new Vector2(jumpHeight, 0);
                angle = 270f;
            }
            else if (angle == 180) {
                Debug.Log("should go down");
                rb.velocity = new Vector2(0, -jumpHeight);
                angle = 0f;
            }
            else if (angle == 270) {
                Debug.Log("should go left");
                rb.velocity = new Vector2(-jumpHeight, 0);
                angle = 90f;
            }
        }
    }
}
