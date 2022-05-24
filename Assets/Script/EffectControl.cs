using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
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
        ParticleSystem effect = Instantiate(DeadEffect, new Vector3(transform.localPosition.x, transform.localPosition.y + 2f, transform.localPosition.z), transform.rotation) as ParticleSystem;
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
                    Destroy(ActiveFollowers.GetChild(i).gameObject, 1.5f);

                }
            }
        }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedFollower" || other.gameObject.tag == "YellowFollower")
        {
            InvokeRepeating("PlayEffect", 0.02f,1f);
            DestroyChild();
            //gameObject.SetActive(false);
            //Follower.gameObject.SetActive(false);
            Debug.Log("red or yellow");
        }




    }
}


