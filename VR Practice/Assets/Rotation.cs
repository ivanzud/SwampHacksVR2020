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
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.right * speed);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.left * speed);

    }
}
