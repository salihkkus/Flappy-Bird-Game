using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public float zıplama_aralığı;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

        void Update()
    {
        if(Input.GetMouseButtonDown(0)){
        rb.velocity = Vector2.up * zıplama_aralığı;
    }
    }
}
