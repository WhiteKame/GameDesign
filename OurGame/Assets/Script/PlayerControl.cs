using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    //public float speed = 2;
    private float speed;
    public float walkspeed = 3f;
    public float rushspeed = 10f;
    private Rigidbody2D rb2d;
    private Animator anim;
    private SpriteRenderer spRenderer;
    private bool checkClick = false;
    private bool onIce = false;
    private AudioSource babo;


    // Start is called before the first frame update
    void Start()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
        this.anim = GetComponent<Animator>();
        this.spRenderer = GetComponent<SpriteRenderer>();
        this.babo = GetComponent<AudioSource>();
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

        if (velx + vely != 0)
        {
            if(!babo.isPlaying)
            {
                babo.Play();
            }

        }
        else
        {
            babo.Stop();
        }
        
        anim.SetFloat("Move", Mathf.Abs((velx + vely) * speed));

        if (x < 0)
        {
            spRenderer.flipX = true;
        }
        else if (x > 0)
        {
            spRenderer.flipX = false;
        }

        if(Input.GetKey(KeyCode.LeftShift) && gameObject.tag != "Gas")
        {
            speed = rushspeed;
        }
        else
        {
            speed = walkspeed;
        }
        //change to gas
        if(Input.GetKeyDown(KeyCode.R))
        {
            if(checkClick == false)
            {
                checkClick = true;
                gameObject.tag = "Gas";
                walkspeed = 1f;
            }
            else if(checkClick == true)
            {
                checkClick = false;
                gameObject.tag = "Player";
                walkspeed = 3f;
            }
            anim.SetBool("clickR", checkClick);
        }

        if(onIce  == true)
        {
            speed = 500f;
        }

    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "Ice")
        {
            onIce = true;
        }
        else
        {
            onIce = false;
        }
        anim.SetBool("onIce", onIce);
    }

    // void OnTriggerExit2D(Collider2D c)
    // {
    //     if (c.tag == "Ice")
    //     {
    //         onIce = false;
    //         Debug.Log("Exit ice");
    //     }
    //     anim.SetBool("onIce", onIce);
    // }
}