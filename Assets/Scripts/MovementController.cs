using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour
{
    private bool clockwise = false;
    private bool isJumping = false;
    private bool onCorner = false;
    private float jumpHeight = 10f;
    private float angle = 0f;
    private float moveSpeed = 6f;
    private SpriteRenderer m_SpriteRenderer;

    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

        rb.velocity = new Vector2(moveSpeed, 0);
        Debug.Log(angle);
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Corner") && isJumping == false) {
            Debug.Log(angle);
            isJumping = false;
            onCorner = true;
            if (clockwise) {
                if (angle != 270) {
                    Debug.Log("reach");
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
                    Debug.Log("reach");
                    angle = 270;
                }
            }
        }
        else if(other.gameObject.CompareTag("Rail")) {
            m_SpriteRenderer = GetComponent<SpriteRenderer>();
            Debug.Log("Rail contact");
            isJumping = false;
            onCorner = false;
            //rb.velocity = new Vector2(0, 0);
            if (angle == 0) {
                rb.velocity = new Vector2(moveSpeed, 0);
                Debug.Log("moving right");
            }
            else if (angle == 90) {
                rb.velocity = new Vector2(0, -moveSpeed);
                Debug.Log("moving down");
            }
            else if (angle == 180) {
                rb.velocity = new Vector2(-moveSpeed, 0);
                Debug.Log("moving left");
            }
            else if (angle == 270) {
                rb.velocity = new Vector2(0, moveSpeed);
                Debug.Log("moving up");
            }  
            if (clockwise) {
                m_SpriteRenderer.color = Color.magenta;
            }
            else {
                m_SpriteRenderer.color = Color.white;
            }
        }
        else if (other.gameObject.CompareTag("Rail2"))
        {
            m_SpriteRenderer = GetComponent<SpriteRenderer>();
            Debug.Log("Rail2 contact");
            isJumping = false;
            onCorner = false;
            //rb.velocity = new Vector2(0, 0);
            if (angle == 0)
            {
                rb.velocity = new Vector2(-moveSpeed, 0);
                Debug.Log("moving right");
            }
            else if (angle == 90)
            {
                rb.velocity = new Vector2(0, moveSpeed);
                Debug.Log("moving down");
            }
            else if (angle == 180)
            {
                rb.velocity = new Vector2(moveSpeed, 0);
                Debug.Log("moving left");
            }
            else if (angle == 270)
            {
                rb.velocity = new Vector2(0, -moveSpeed);
                Debug.Log("moving up");
            }
            if (clockwise)
            {
                m_SpriteRenderer.color = Color.magenta;
            }
            else
            {
                m_SpriteRenderer.color = Color.white;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

        //jumping
        if (Input.GetKeyDown("space") && !isJumping && !onCorner)
        {
            isJumping = true;
            clockwise = !clockwise;
            moveSpeed = -moveSpeed;
            Debug.Log("jumping");

            if (angle == 0) {
                rb.velocity = new Vector2(0, jumpHeight);
                angle = 180f;
            }
            else if (angle == 90) {
                rb.velocity = new Vector2(jumpHeight, 0);
                angle = 270f;
            }
            else if (angle == 180) {
                rb.velocity = new Vector2(0, -jumpHeight);
                angle = 0f;
            }
            else if (angle == 270) {
                rb.velocity = new Vector2(-jumpHeight, 0);
                angle = 90;
            }
            
        }
    }
}
