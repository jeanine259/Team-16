using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        // Camera always looks at the center of the scene
        // x = 0, y = 0, z = 0
        transform.LookAt(Vector3.zero);
        float speed = 10.0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector3.right * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.up * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.Equals))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.Minus))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }
    }
}