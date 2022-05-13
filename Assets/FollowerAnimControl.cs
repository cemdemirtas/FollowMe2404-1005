using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerAnimControl : MonoBehaviour
{
    public static FollowerAnimControl instance;
    public Animator anim;
   public bool Run_on = false;
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }

        anim = transform.GetComponent<Animator>();
    }

    void Start()
    {

        anim.SetBool("Idle", true);


    }

    void Update()
    {
        if (Run_on == false)
        {
            anim.SetBool("Idle", true);
        }

        if (Run_on == true)
        {
            anim.SetBool("Run", true);
            anim.SetBool("Idle", false);
        }
    }


}
