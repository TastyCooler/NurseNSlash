using UnityEngine;

public class Hero : MonoBehaviour
{


    Rigidbody2D myRigidBody2D;
    public float playerSpeed = 4f;
    Vector2 targetVelocity;

    private Animator animator;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    float nextFire;
    public Vector2 angle;
    

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();

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

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && Time.time > nextFire)
        {
            
            angle = transform.right;
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && Time.time > nextFire)
        {
            angle = new Vector2(-1, 0); 
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time > nextFire)
        {
            angle = transform.up;
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && Time.time > nextFire)
        {
            angle = new Vector2(0, -1);
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }

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
