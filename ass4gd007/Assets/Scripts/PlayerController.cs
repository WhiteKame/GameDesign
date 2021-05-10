using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rd;
    private float moveH, moveV;

    // Start is called before the first frame update
    private void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        moveH = Input.GetAxisRaw("Horizontal");
        moveV = Input.GetAxisRaw("Vertical");
    }

    private void Move() {
        rd.velocity = new Vector2(moveH, moveV);
    }
}
