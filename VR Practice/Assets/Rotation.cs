using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.rotation.x);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.rotation.x < 0.7)
                transform.Rotate(Vector3.right * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.rotation.x > -0.7)
                transform.Rotate(Vector3.left * speed);
        }
    }
}
