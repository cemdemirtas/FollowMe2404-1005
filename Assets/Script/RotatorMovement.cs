using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorMovement : MonoBehaviour
{

    float speed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1)*speed);
    }

}
