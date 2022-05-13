using UnityEngine;
using System.Collections;

public class DirectionalMove : MonoBehaviour
{

    // Animation script
    //private CharacterAnimation anim;
    public Rigidbody rb;
    public Animator anim;
    public static int score;

    //placeholder positions for cube to jump to

    private int Direction;

    public float speed;
    private bool grounded;
    private bool immediateDown;
    private bool moved;


    public static bool dead;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame (Right before frame)
    void Update()
    {

        //Restricted position X.
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9, 4.5f), transform.position.y, transform.position.z);

        //transform.position = transform.position + Vector3.forward * Time.deltaTime * 10;

        //rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y,10f);
        //Debug.Log(grounded);

        //{
        //    Analyze();
        //    if (Input.GetKeyDown(KeyCode.A))
        //    {
        //        print("left");

        //        Direction -= 2;

        //    }
        //    if (Input.GetKeyDown(KeyCode.D))
        //    {
        //        print("right");


        //        Direction += 2;

        //    }

        //    if (Input.GetKeyDown(KeyCode.S))
        //    {
        //        immediateDown = true;
        //    }

        //}



        //void Analyze()
        //{
        //    transform.position = Vector3.Lerp(transform.position, new Vector3(3 * Direction, transform.position.y, transform.position.z), 3.7f * Time.deltaTime);
        //}




        //    void FixedUpdate()
        //    {
        //        if (immediateDown)
        //        {
        //            rb.AddForce(0, -3000f, 0);
        //            immediateDown = false;
        //        }
        //    }
        //}

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Finish")
        {
            transform.rotation = Quaternion.Euler(0, -180f, 0);
            Destroy(transform.GetComponent<SwerveInput>());
            anim.SetBool("Dance", true);
            anim.SetBool("Run", false);
            anim.SetBool("Dance", true);
        }


    }
}

