using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selfbutton : MonoBehaviour
{
    public GameObject gate;
    private CircleCollider2D collision;
    // Start is called before the first frame update
    void Start()
    {
        this.collision = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        this.gameObject.SetActive(false);
        gate.gameObject.SetActive(false);
    }
}
