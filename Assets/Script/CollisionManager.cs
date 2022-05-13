using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    
    Vector3 desirePos;
    public GameObject MainCharacter;
    public GameObject Follower;
    MoveFollower move;


    void Start()
    {
    }

    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        //MoveFollower.instance.GetComponent<MoveFollower>().i = MoveFollower.instance.GetComponent<MoveFollower>().i + 2;
        //MoveFollower.instance.i = MoveFollower.instance.i + 2;
        
        if (other.gameObject.CompareTag("Follower"))
        {
            SoundController.Instance.PlayStackSound();
            other.gameObject.GetComponent<FollowerAnimControl>().Run_on = true;
            Debug.Log("we hit");
            other.transform.position = transform.position + new Vector3(0, 0, 5);
            Destroy(transform.GetComponent<CollisionManager>());
            other.gameObject.AddComponent<CollisionManager>();
            Destroy(transform.GetComponent<PlayerControl>());
            other.gameObject.AddComponent<PlayerControl>();
            other.transform.GetComponent<CapsuleCollider>().isTrigger = false;

            other.gameObject.AddComponent<MoveFollower>();
            other.gameObject.transform.GetComponent<MoveFollower>().Last = transform;
            
            Debug.Log(MoveFollower.instance.GetComponent<MoveFollower>().i);
            other.transform.GetComponent<Rigidbody>().isKinematic = true;
            //other.gameObject.AddComponent<DirectionalMove>();
            //transform.GetComponent<DirectionalMove>().enabled = false;
            other.transform.gameObject.tag = "Stacked";
            
        }



   
    }


}
