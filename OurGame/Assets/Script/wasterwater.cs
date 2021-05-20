using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wasterwater : MonoBehaviour
{
    private CompositeCollider2D collision;
    //private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        this.collision = GetComponent<CompositeCollider2D>();
        //this.audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        //audio.Play();
    }
}
