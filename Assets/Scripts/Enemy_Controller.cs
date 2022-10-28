using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Controller : MonoBehaviour
{
    private Transform konum;
    public float speed;

    void Start()
    {
        konum = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, konum.position, speed * Time.deltaTime);
    }
}
