using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    [SerializeField] private AudioClip deathSound;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void deathSoundPlay() {
        audioSource.clip = deathSound;
        audioSource.Play();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            deathSoundPlay();
            MovementController mc = collision.transform.GetComponent<MovementController>();
            mc.Reset();
        }
    }

}
