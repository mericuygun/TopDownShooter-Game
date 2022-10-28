using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public Rigidbody2D rb;
    public Animator anim;
    public float speed;
    private Vector2 movement;

    void Start()
    {
        
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(movement.x * speed, movement.y * speed);
        runAnim();

    }

    private void runAnim()
    {
        if (movement.x != 0 || movement.y != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }
    
}
