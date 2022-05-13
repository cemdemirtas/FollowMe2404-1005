using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierMovement : MonoBehaviour
{

    private float speed = 0.5f;
    public float rotFl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, Mathf.PingPong(Time.time * 50, rotFl),0);

    }
}

