using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_movement : MonoBehaviour
{

    public GameObject player;
    public float sensitivity;
    public float speed;
    //public Camera mycam;

    // Start is called before the first frame update
    void Start()
    {
        // start
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(mycam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane)), Vector3.up);
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        // transform.RotateAround(player.transform.position, -Vector3.up, rotateHorizontal * sensitivity); 
        //use
        transform.Rotate(-transform.up * rotateHorizontal * sensitivity); //instead if you dont want the camera to rotate around the player
                                                                          // transform.RotateAround(Vector3.zero, transform.right, rotateVertical * sensitivity); 
                                                                          // again, use
        transform.Rotate(transform.right * rotateVertical * sensitivity); //if you don't want the camera to rotate around the player

        float xDir = Input.GetAxis("Horizontal");
        float yDir = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDir, 0.0f, yDir);
        transform.position += moveDirection;

        // Fire
        if (Input.GetMouseButtonDown(0)) {
            player_behavior.Fire();
        }

        if (Input.GetKey("w"))
        {
            Debug.Log("Forward");   
        }
        if (Input.GetKey("a"))
        {
            Debug.Log("Left");
        }
        if (Input.GetKey("s"))
        {
            Debug.Log("Backward");
        }
        if (Input.GetKey("d"))
        {
            Debug.Log("Right");
        }       

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "zombie")
        {
            player_behavior.TakeDamage();
        }
    }
}
