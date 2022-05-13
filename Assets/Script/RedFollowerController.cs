using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFollowerController : MonoBehaviour
{
    public Transform ActiveFollowers, RedFollowersParent;
    public GameObject Redfollower;
    int RandomPosX, RandomPosZ;
    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag=="Stacked")
        //{
        //    //De1stroy(other.gameObject.transform.GetComponent<MoveFollower>());
        //    other.gameObject.SetActive(false);
        //    other.gameObject.transform.tag = "Blocked";
        //}

      
    }

    private void Start()
    {

    }
}
