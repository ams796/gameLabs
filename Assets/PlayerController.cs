using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed;
    public float jumpheight;

    public KeyCode spacebar;
    public KeyCode up;
    public KeyCode R;
    public KeyCode L;

    private bool IsFacingRight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(spacebar) || Input.GetKeyDown(up) && grounded)
        {
            jump();
        }

        if(Input.GetKey(L))
        {
            GetComponent <Rigidbody2D>().velocity= new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        
            if(GetComponent<SpriteRenderer>() != null)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }

        }

         if(Input.GetKey(R))
         {
            GetComponent <Rigidbody2D>().velocity= new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        
            if(GetComponent<SpriteRenderer>() != null)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
        
        }


        if (!Input.GetKey(L) && !Input.GetKey(R))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }


       


    }

    void jump()
    {
        GetComponent <Rigidbody2D>().velocity= new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpheight);
    }


    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

}
