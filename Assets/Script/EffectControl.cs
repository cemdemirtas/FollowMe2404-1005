using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectControl : MonoBehaviour
{
    public static EffectControl Instance;
    public Transform Follower, ActiveFollowers;

    public ParticleSystem DeadEffect;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void FixedUpdate()
    {
        DeadEffect.transform.position = transform.position;
    }
    void Start()
    {
        transform.GetComponent<ParticleSystem>();
        DeadEffect = GameObject.Find("FrostDeath").GetComponent<ParticleSystem>();

    }

    public void PlayEffect()
    {
        ParticleSystem effect = Instantiate(DeadEffect, new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z), transform.rotation) as ParticleSystem;
        effect.Play();
    }

    public void DestroyChild()
    {
        //if (ActiveFollowers != null)
        //{
            if (ActiveFollowers.childCount != null)
            {
                for (int i = 0; i < ActiveFollowers.childCount; i++)
                {
                    //ActiveFollowers.GetChild(i).gameObject.SetActive(false);
                    Destroy(ActiveFollowers.GetChild(i).gameObject, 0.5f);

                }
            }
        }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedFollower" || other.gameObject.tag == "YellowFollower")
        {

            PlayEffect();
            DestroyChild();
            //gameObject.SetActive(false);
            //Follower.gameObject.SetActive(false);

            Debug.Log("red or yellow");
        }




    }
}


