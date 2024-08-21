using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSesi : MonoBehaviour
{
    private AudioSource audioSource;
    
    public AudioClip coinSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
           
            if (coinSound != null)
            {
                audioSource.PlayOneShot(coinSound);
            }
        }
    }
}
