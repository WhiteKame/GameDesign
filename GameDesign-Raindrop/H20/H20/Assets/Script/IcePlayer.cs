using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcePlayer : MonoBehaviour
{


    private float speed;
    public float walkspeed = 5f;
    public float rushspeed = 9f;
    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 position = transform.position;
        position.x += moveX * speed * Time.deltaTime;
        position.y += moveY * speed * Time.deltaTime;
        rbody.position = position;


        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = rushspeed;

        }
        else
        {
            speed = walkspeed;
        }

    }
}
