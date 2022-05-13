using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFollower : MonoBehaviour
{
    public static MoveFollower instance;

    bool IsDeactive = false;
    //Vector3 desirePos;
    //public GameObject mainCharacter;
    public Transform Last;
    public GameObject mainCharacter;
   public float i = 1.5f;

    public void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
    }


    void Start()
    {

        //transform.GetComponent<MoveFollower>().enabled = false;
    }

    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, Last.position.x, Time.deltaTime * 20),  //we provide smoothly
            transform.position.y,
            Last.position.z + i // last character pos.z + 5
            );
        //transform.position = new Vector3(
        //  transform.position.x,  //we provide smoothly
        //  Last.position.y+1,
        //  transform.position.z // last character pos.z + 5
        //  );


        //desirePos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 15);
        //transform.position = Vector3.Lerp(mainCharacter.transform.position, desirePos, Time.deltaTime * 2);

        //if (Last.gameObject.activeInHierarchy == false)
        //{
        //    Debug.Log("test");

        //    gameObject.AddComponent<CollisionManager>();
        //}


    }
    

}
