using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIt : MonoBehaviour
{
    private bool moveRight;
    private float xVal;
    private Vector3 idk;

    // Start is called before the first frame update
    void Start()
    {
        moveRight = true;
        xVal = transform.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveRight && transform.position.x <= 3)
        {
            xVal += new Vector3(1,0,0).normalized.x * Time.deltaTime;
            transform.position = new Vector3(xVal, transform.position.y, transform.position.z);

        }

        else
        {
            moveRight = false;

            xVal -= new Vector3(1, 0, 0).normalized.x * Time.deltaTime;
            transform.position = new Vector3(xVal, transform.position.y, transform.position.z);

            moveRight = xVal <= -3;
        }

        //if (moveRight && transform.position != new Vector3(3, 1, 0))
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, new Vector3(3, 1, 0), Time.deltaTime);

        //}

        //else
        //{
        //    moveRight = false;
        //    transform.position = Vector3.MoveTowards(transform.position, new Vector3(-3, 1, 0), Time.deltaTime);
        //    moveRight = transform.position == new Vector3(-3, 1, 0) ? true : false;
        //}

    }
}
