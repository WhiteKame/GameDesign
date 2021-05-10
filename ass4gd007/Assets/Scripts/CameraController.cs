using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;
    [SerializeField] private float smoothSpeed;
    [SerializeField] private float minX, maxX, minY, maxY;

    // Start is called before the first frame update
    private void Start()
    {
        //target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = PlayerController.instance.transform;
    }

    // Update is called once per frame
    private void Update()
    {
        //trantional camera movement
        //transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        
        //smooth camera
        //parameter1; current position of player
        //parameter2: target position
        //parameter3: speed
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, target.position.y, transform.position.z), smoothSpeed * Time.deltaTime);

        //dinfine the cinmera range
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), //limit x
                                         Mathf.Clamp(transform.position.y, minY, maxY), //limit y
                                         transform.position.z);
    }
}
