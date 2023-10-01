using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeIt : MonoBehaviour
{
    private float origSize;
    private float newSize;

    private bool inc;
  

    // Start is called before the first frame update
    void Start()
    {
        inc = true;
        // Original size of x is the same for y and z
        origSize = newSize = transform.localScale.x;        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inc && newSize <= origSize * 4)
        {
            newSize += new Vector3(1,0,0).normalized.x * Time.deltaTime;
            transform.localScale = new Vector3(newSize, newSize, newSize);
        }

        else
        {
            inc = false;

            newSize -= new Vector3(1, 0, 0).normalized.x * Time.deltaTime;
            transform.localScale = new Vector3(newSize, newSize, newSize);

            inc = newSize <= origSize;
        }

    }
}
