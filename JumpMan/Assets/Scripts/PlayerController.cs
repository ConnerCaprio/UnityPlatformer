using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed;
    public float jumpHeight;
    public bool isGrounded;
    public LayerMask groundLayers;

    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        isGrounded = Physics2D.OverlapArea(new Vector2(transform.position.x - .5f, transform.position.y - .875f),
            new Vector2(transform.position.x + .5f, transform.position.y - .875f), groundLayers);

        if (Input.GetKey("up"))
        {
            if (isGrounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            }
            
            
        }

        if (isGrounded)
        {
            if (Input.GetKey("left"))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed * -1, GetComponent<Rigidbody2D>().velocity.y);
            }
            else if (Input.GetKey("right"))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, GetComponent<Rigidbody2D>().velocity.y);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
            }
            anim.SetFloat("SpeedX", GetComponent<Rigidbody2D>().velocity.x);
            anim.SetBool("grounded", true);
        }
        else
        {
            if (Input.GetKey("left"))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed * -1, GetComponent<Rigidbody2D>().velocity.y);
            }
            else if (Input.GetKey("right"))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(movementSpeed, GetComponent<Rigidbody2D>().velocity.y);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
            }
            anim.SetBool("grounded", false);
            anim.SetFloat("SpeedX", GetComponent<Rigidbody2D>().velocity.x);
        }
    }
}
