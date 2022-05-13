using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ActiveFollowers,target;
    Vector3 whereCameraShouldBe;
    Vector3 generalOffset;

    void Start()
    {
        
    }

    void Update()
    {
        int countOfFollower = ActiveFollowers.childCount - 1; // We collect followers and the last node should contain camera.

        if (ActiveFollowers.childCount>=1) 
        {
            target = ActiveFollowers.GetChild(countOfFollower).gameObject.transform;

            generalOffset = transform.position - target.position;
            transform.parent = ActiveFollowers.GetChild(countOfFollower); //last node
            whereCameraShouldBe = target.position + generalOffset;
            transform.position = Vector3.Lerp(transform.position, generalOffset, Time.deltaTime * 5);


        }
    }
}
