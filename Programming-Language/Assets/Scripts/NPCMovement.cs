using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    //Speed at which you want the gameobject to move
    public int speed;

    //Decied which direction you want the object to move in
    public bool goForward = false;
    public bool goBackwards = false;
    public bool goRight = false;
    public bool goLeft = false;

    //Rotate Right or Left on Y Axis
    public bool yRotateRight = false;
    public bool yRotateleft = false;
    public bool xRotateup = false;
    public bool xRotatedown = false;
    public bool zRotateRight = false;
    public bool zRotateleft = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        //Directional Movement
        if (goForward == true)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if (goBackwards == true)
        {
            transform.position += transform.forward * -speed * Time.deltaTime;
        }
        else if(goRight == true)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else if (goLeft == true)
        {
            transform.position += transform.right * -speed * Time.deltaTime;
        }


        if (yRotateRight == true)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * speed);
        }
        else if (yRotateleft == true)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * -speed);
        }
        else if (xRotateup == true)
        {
            transform.Rotate(Vector3.left, Time.deltaTime * speed);
        }
        else if (xRotatedown == true)
        {
            transform.Rotate(Vector3.left, Time.deltaTime * -speed);
        }
        else if (zRotateRight == true)
        {
            transform.Rotate(Vector3.back, Time.deltaTime * speed);
        }
        else if (zRotateleft == true)
        {
            transform.Rotate(Vector3.back, Time.deltaTime * -speed);
        }
    }
}
