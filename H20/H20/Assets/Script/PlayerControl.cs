using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //public float speed = 2;
    private float speed;
    public float walkspeed = 3f;
    public float rushspeed = 6f;
    private Rigidbody2D rb2d;
    private Animator anim;
    private SpriteRenderer spRenderer;



    // Start is called before the first frame update
    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();
        this.spRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        //rb2d.AddForce(Vector2.right * x * speed);

        float y = Input.GetAxisRaw("Vertical");
        //rb2d.AddForce(Vector2.up * y * speed);
        rb2d.velocity = new Vector2(x * speed, y * speed);

        float velx = rb2d.velocity.x;
        float vely = rb2d.velocity.y;

        anim.SetFloat("Speed", Mathf.Abs((velx + vely) * speed));

        if (x < 0)
        {
            spRenderer.flipX = true;
        }
        else if (x > 0)
        {
            spRenderer.flipX = false;
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = rushspeed;

        }
        else
        {
            speed = walkspeed;
        }


    }
}