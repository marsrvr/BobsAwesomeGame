using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed; // character speed.
    private Rigidbody2D rb; // character body
    private float moveInputH; // control input Horizontal

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Updates physics engine.
    private void FixedUpdate()
    {  // -1 is left, 0 still, 1 is right
        moveInputH = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * moveInputH, rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
