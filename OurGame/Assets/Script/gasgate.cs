using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasgate : MonoBehaviour
{
    CompositeCollider2D m_ObjectCollider;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        m_ObjectCollider = GetComponent<CompositeCollider2D>();
        m_ObjectCollider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.tag == "Gas")
        {
            m_ObjectCollider.isTrigger = true;
        }
        else
        {
            m_ObjectCollider.isTrigger = false;
        }
    }

    // void OnCollisionEnter2D (Collision2D collison)
    // {
    //     if(collison.gameObject.tag == "Gas")
    //     {
    //         m_ObjectCollider.isTrigger = true;
    //     }
    // }

    // void OnCollisionExit2D (Collision2D collison)
    // {
    //     if(collison.gameObject.tag == "Gas")
    //     {
    //         m_ObjectCollider.isTrigger = false;
    //     }
    // }
}
