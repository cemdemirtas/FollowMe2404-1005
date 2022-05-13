using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInput : MonoBehaviour
{
    public Animator anim;
    private float LastFrameFingerPosX;
    private float MoveFactorX;
    public float _MoveFactorX => MoveFactorX;

    void Start()
    {
        anim.SetBool("Run", false);
        anim.SetBool("Idle", true);
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LastFrameFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            anim.SetBool("Run", true);
            anim.SetBool("Idle", false);

            transform.position = transform.position + Vector3.forward * Time.deltaTime * 10;

            MoveFactorX = Input.mousePosition.x - LastFrameFingerPosX;
            LastFrameFingerPosX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("Run", false);
            anim.SetBool("Idle", true);
            MoveFactorX = 0;
        }


    }
}
