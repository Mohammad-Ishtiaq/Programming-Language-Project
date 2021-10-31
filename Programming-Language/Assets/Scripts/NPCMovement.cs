using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public int speed;

    public bool goForward = true;
    public bool goRight = false;
    public bool goLeft = false;

    public bool rotateRight = false;
    public bool rotateleft = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (goForward == true)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if(goRight == true)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else if (goLeft == true)
        {
            transform.position += transform.right * -speed * Time.deltaTime;
        }


        if (rotateRight == true)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * speed);
        }
        else if (rotateleft == true)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * -speed);
        }
    }
}
