using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Vector3 cameraPos;
    // Start is called before the first frame update
    void Start()
    {
        cameraPos = new Vector3(5.5f, 8.5f, -12);
        transform.Rotate(30, -25, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            cameraPos.z += new Vector3(0, 0, 0.5f).z * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            cameraPos.z -= new Vector3(0, 0, 0.5f).z * Time.deltaTime;
        }

        transform.position = cameraPos;
    }
}
