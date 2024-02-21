using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1HotblockScript : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    public float timer;
    public float currentTime;
    private int i = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > timer)
        {
            switch (i)
            {
                case 0:
                    rb.velocity = new Vector2(2, 0);
                    i++;
                    break;
                case 1:
                    rb.velocity = new Vector2(0, 2);
                    i++;
                    break;
                case 2:
                    rb.velocity = new Vector2(-2, 0);
                    i++;
                    break;
                case 3:
                    rb.velocity = new Vector2(0, -2);
                    i = 0;
                    break;
            }
            currentTime = 0;
        }
        currentTime += Time.deltaTime;
    }
}
