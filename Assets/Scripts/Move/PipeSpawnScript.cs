using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public float maxtime = 1;
    public float timer = 0;
    public float yukseklik;
    public GameObject pipe;

    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-yukseklik,yukseklik),0);
    }
    void Update()
    {
        if(timer > maxtime)
        {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-yukseklik,yukseklik),0);
        Destroy(newpipe, 15);
        timer = 0;
        }
       
    timer += Time.deltaTime;  

    }
}
