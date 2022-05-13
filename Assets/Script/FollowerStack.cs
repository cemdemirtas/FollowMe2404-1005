using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerStack : MonoBehaviour
{
    Vector3 desirePos;
    public GameObject MainCharacter;
    void Start()
    {

    }

    void Update()
    {
        desirePos = new Vector3(MainCharacter.transform.position.x, MainCharacter.transform.position.y, MainCharacter.transform.position.z + 5);

        transform.position= Vector3.Lerp(transform.position,desirePos,Time.deltaTime*2);
        //Vector3.MoveTowards(transform.position, desirePos, 1000);

    }



}
