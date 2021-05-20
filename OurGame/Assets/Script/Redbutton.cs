using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redbutton : MonoBehaviour
{
    public GameObject gate;
    private Animator anim;
    private CircleCollider2D collision;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        this.collision = GetComponent<CircleCollider2D>();
        this.anim = GetComponent<Animator>();
        this.audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision) {
        //Debug.Log("OnTriggerEnter:" + collision.transform.name);
        anim.SetBool("isTrigger", true);
        gate.gameObject.SetActive(false);
        audio.Play();
    }

    void OnTriggerExit2D(Collider2D collision) {
        //Debug.Log("OnTriggerEnter:" + collision.transform.name);
        anim.SetBool("isTrigger", false);
    }
}
