using UnityEngine;

public class Hero : MonoBehaviour
{


    Rigidbody2D myRigidBody2D;
    [Range(0, 2.5f)]
    public float playerSpeed = 4f;
    Vector2 targetVelocity;

    private Animator animator;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    float nextFire;


    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation) ;
        }
        
    }

    private void FixedUpdate()
    {
        Movement();
        Animation(); 
    }

    void Movement()
    {
        targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;
    }

   

    void Animation()
    {
        if (targetVelocity.x > 0)
        {
            animator.SetInteger("Direction", 2);
        }
        else if (targetVelocity.x < 0)
        {
            animator.SetInteger("Direction", 4);
        }
        else if (targetVelocity.y > 0)
        {
            animator.SetInteger("Direction", 3);
        }
        else if (targetVelocity.y < 0)
        {
            animator.SetInteger("Direction", 1);
        }
        else
        {
            animator.SetInteger("Direction", 0);
        }
    }
}
