using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3
        (
            player.transform.position.x,
            player.transform.position.y,
            this.transform.position.z
        );
        // fix x
        if (this.transform.position.x < -6)
        {
            transform.position = new Vector3
            (
                -6,
                this.transform.position.y,
                this.transform.position.z
            );
        }
        else if (this.transform.position.x > 6)
        {
            transform.position = new Vector3
            (
                6,
                this.transform.position.y,
                this.transform.position.z
            );
        }
        // fix y
        if (this.transform.position.y < 0)
        {
            transform.position = new Vector3
            (
                this.transform.position.x,
                0,
                this.transform.position.z
            );
        }
        else if (this.transform.position.y > 22)
        {
            transform.position = new Vector3
            (
                this.transform.position.x,
                22,
                this.transform.position.z
            );
        }
    }
}
