using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ÖlümSesi : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip deathSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            if (deathSound != null)
            {
                audioSource.PlayOneShot(deathSound);
            }

            Time.timeScale = 0;
        }
    }
}

