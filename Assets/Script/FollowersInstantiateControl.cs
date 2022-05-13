using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowersInstantiateControl : MonoBehaviour
{
    float setZ = 2;
    NavMeshAgent nav;
    public GameObject MainCharacter;
    public Animator anim;
    public List<GameObject> followers;
    public Transform FollowersParent, RedFollowersParent, YellowFollowersParent;
    float RandomPosXLeft, RandomPosXRight, RandomPosXCenter, RandomPosZ, RandomPosX;
    List<float> Xvalues = new List<float>();
    public GameObject follower, Redfollower, Yellowfollower;
    public void Awake()
    {
        RandomPosXLeft = -8;
        RandomPosXRight = 2;
        RandomPosXCenter = 0;
        Xvalues.Add(RandomPosXRight);
        Xvalues.Add(RandomPosXLeft);
        Xvalues.Add(RandomPosXCenter);



        nav = GetComponent<NavMeshAgent>();

        anim = GetComponent<Animator>();
        anim.SetBool("Idle1", true);
        anim.SetBool("Run", false);
    }

    private void FixedUpdate()
    {
        int rndm = Random.RandomRange(0, 2);

        RandomPosZ = Random.Range(-10, 238);

        if (RedFollowersParent != null)
        {
            //RedFollower instantiate
            if (RedFollowersParent.childCount <= 3) // clone 15 followers
            {
                GameObject InstantiateFollower = (GameObject)Instantiate(Redfollower, new Vector3(Xvalues[Random.RandomRange(1, 3)], transform.position.y, Random.Range(-10, 238)), Quaternion.identity);
                float distance = Mathf.Abs(InstantiateFollower.transform.position.z - MainCharacter.transform.position.z);

                //InstantiateFollower.transform.SetParent(FollowersParent);
                InstantiateFollower.transform.name = "RedClonefollower" + Random.RandomRange(0, 150);
                InstantiateFollower.transform.parent = RedFollowersParent.transform;
            }

        }
    }
    void Update()
    {


        //RandomPosX = Random.Range(-8.6f, 4.4f);


        anim.SetBool("Run", true);
        anim.SetBool("Idle1", false);
        //blue follower
        if (FollowersParent != null)
        {
            if (FollowersParent.childCount <= 10) // clone 15 followers
            {
                GameObject InstantiateFollower = (GameObject)Instantiate(follower, new Vector3(Xvalues[Random.RandomRange(1, 3)], transform.position.y, Random.Range(-10, 238)), Quaternion.identity);
                float distance = Mathf.Abs(InstantiateFollower.transform.position.z - MainCharacter.transform.position.z);

                //InstantiateFollower.transform.SetParent(FollowersParent);
                InstantiateFollower.transform.name = "Blueclonefollower" + Random.RandomRange(0, 150);
                InstantiateFollower.transform.parent = FollowersParent.transform;

                for (int i = 0; i < FollowersParent.childCount; i++)
                {
                    followers.Add(FollowersParent.GetChild(i).gameObject);
                }


            }
        }
        if (YellowFollowersParent != null)
        {
            if (YellowFollowersParent.childCount <= 3) // clone 15 followers
            {
                GameObject InstantiateFollower = (GameObject)Instantiate(Yellowfollower, new Vector3(Xvalues[Random.RandomRange(1, 3)], transform.position.y, Random.Range(-10, 238)), Quaternion.identity);
                float distance = Mathf.Abs(InstantiateFollower.transform.position.z - MainCharacter.transform.position.z);

                //InstantiateFollower.transform.SetParent(FollowersParent);
                InstantiateFollower.transform.name = "YellowClonefollower" + Random.RandomRange(0, 150);
                InstantiateFollower.transform.parent = YellowFollowersParent.transform;




            }
        }
    }


}
