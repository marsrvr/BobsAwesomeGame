using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;       // character speed.

    public float jumpForce;   // How much are we jumping?
    public float jumpsAllowed; // How many mid-air jumps
    private float timesJumped; // Jump counter
    private float previousJumpInput; // hogging the jump key?

    private Rigidbody2D rb;   // character body

    private float moveInputH; // control input Horizontal
    private float jumpInputV; // control jump input vertical
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timesJumped = 0;
        previousJumpInput = 0;
    }

    // Updates physics engine.
    private void FixedUpdate()
    {  
        // -1 is left, 0 still, 1 is right
        moveInputH = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * moveInputH, rb.velocity.y);

        // -1 is down, 0 is still, 1 is up
        jumpInputV = Input.GetAxis("Vertical");
        if (jumpInputV > 0 && timesJumped < jumpsAllowed && previousJumpInput == 0) // is a float
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            timesJumped++;
        }

        previousJumpInput = jumpInputV;

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            timesJumped = 0;
        }
        else if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
