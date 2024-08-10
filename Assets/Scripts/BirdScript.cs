using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{

    public Text skor_text;
    public float skor;
    public float zıplama_aralığı;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        skor = 0;
    }

        void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
        rb.velocity = Vector2.up * zıplama_aralığı;
        }

        skor_text.text = skor.ToString();
    }

    void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag == "Scorer")
        {
        skor++;
        }
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Pipe")
        {
            Time.timeScale = 0;
        }
    }

    
}
