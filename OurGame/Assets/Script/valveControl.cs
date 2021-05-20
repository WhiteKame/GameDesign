using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class valveControl : MonoBehaviour
{
    public GameObject wasterwater;
    private Animator anim;
    private CircleCollider2D collision;
    public float waitTime = 0.0f;
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
        wasterwater.gameObject.SetActive(false);
        audio.Play();
    }

    void OnTriggerExit2D(Collider2D collision) {
        //Debug.Log("OnTriggerEnter:" + collision.transform.name);
        anim.SetBool("isTrigger", false);
        
        StartCoroutine(valveControl.DelayToInvokeDo(() => {wasterwater.gameObject.SetActive(true);}, waitTime));
    }

    public static IEnumerator DelayToInvokeDo(Action action, float delaySeconds)
    {
        yield return new WaitForSeconds(delaySeconds);
        action();
    }
}
