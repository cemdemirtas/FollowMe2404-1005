using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Transform ActiveFollower;
    MoveFollower movefollowerscript;

    private void Update()
    {
        if (gameObject.transform.tag == "Stacked")
        {
            gameObject.transform.GetComponent<CapsuleCollider>().isTrigger = false;
            //other.gameObject.transform.parent = ActiveFollower.transform;
            //ActiveFollower.SetAsFirstSibling();
        }
    }

    private void Start()
    {
        movefollowerscript = gameObject.GetComponent<MoveFollower>();
        transform.GetComponent<CapsuleCollider>();
        ActiveFollower = GameObject.Find("ActiveFollowers").transform;
    }


    private void OnTriggerEnter(Collider other) // sort by collision priority.
    {

      


        if (movefollowerscript == null)
        {
         

            if (other.gameObject.transform.tag == "Follower")
            {

                if (gameObject.transform.tag == "Stacked")
                {

                    transform.gameObject.transform.parent = ActiveFollower.transform;

                    other.gameObject.transform.parent = ActiveFollower.transform;
                    ActiveFollower.SetAsFirstSibling();
                    



                }




            }







            //if (ActiveFollower.childCount > 1 || !ActiveFollower.GetChild(transform.childCount).gameObject.AddComponent<CollisionManager>())
            //{
            //    ActiveFollower.GetChild(transform.childCount).gameObject.AddComponent<CollisionManager>();
            //    Debug.Log("addeddd");
            //}

            //if (other.gameObject.transform.tag == "Player") // first node while we first hit other followers.
            //{
            //    if (gameObject.transform.tag == "Stacked")
            //    {
            //        transform.gameObject.transform.parent = ActiveFollower.transform;
            //        ActiveFollower.SetAsFirstSibling();

            //    }
            //}

        }


        //-----------
        //if (other.gameObject.transform.tag == "Follower")
        //{


        //    if (ActiveFollower.transform.GetComponentInChildren<PlayerControl>())
        //    {
        //        if (gameObject.transform.tag == "Stacked")
        //        {
        //            other.gameObject.transform.parent = ActiveFollower.transform;
        //            ActiveFollower.SetAsFirstSibling();
        //        }


        //    }



        //}

        //if (other.gameObject.transform.tag == "Player") // first node while we first hit other followers.
        //{
        //    if (gameObject.transform.tag == "Stacked")
        //    {
        //        transform.gameObject.transform.parent = ActiveFollower.transform;
        //        ActiveFollower.SetAsFirstSibling();

        //    }
        //}
        //--------------------
    }











}





