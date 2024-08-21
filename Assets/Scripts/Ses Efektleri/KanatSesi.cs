using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KanatSesi : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip flapSound;

    private Rigidbody2D rb;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * 5; 

            if (flapSound != null)
            {
                audioSource.PlayOneShot(flapSound); 
            }
        }
    }
}
