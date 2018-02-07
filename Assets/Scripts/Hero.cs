using UnityEngine;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    Rigidbody2D myRigidBody2D;
    public float playerSpeed = 4f;
    Vector2 targetVelocity;

    public GameObject shot; // Refers to Projectiles
    public Transform shotSpawn; // Where to create a Projectile
    public float fireRate; // Restricts spammers
    float nextFire;
    public Vector2 angle; // Variable for the Projectile angles

    public int damage = 1; 
    public int hp = 3;
    public bool bulletpowerup; // Picked up Bulletpowerup; Yes or No.

    public SpriteRenderer sp;
    public Sprite left,right,down,up;
    private Animator animator;

    public AudioClip shootSound;
    private AudioSource source;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    

    private void Awake()
    {

        source = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
       // Debug.LogFormat("Heros hp:{0} Heros dmg:{1}", hp, damage);
        damageup();
        
    }

    private void FixedUpdate()
    {
        Movement();
        Animation(); 
    }

    // Movement Function
    void Movement()
    {
        targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;
    }

    // Shooting Function
    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && Time.time > nextFire )
        {
            sp.GetComponent<SpriteRenderer>().sprite = right;
            angle = transform.right;
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);

        } 
         if (Input.GetKeyDown(KeyCode.LeftArrow) && Time.time > nextFire)
        {
            sp.GetComponent<SpriteRenderer>().sprite = left;
            angle = new Vector2(-1, 0); 
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);

        }
         if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time > nextFire)
        {
            sp.GetComponent<SpriteRenderer>().sprite = up;
            angle = transform.up;
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);



        }
         if (Input.GetKeyDown(KeyCode.DownArrow) && Time.time > nextFire)
        {
            sp.GetComponent<SpriteRenderer>().sprite = down;
            angle = new Vector2(0, -1);
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);



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

    // increases the damage after triggering the bullet powerup
    void damageup()
    {
        if (bulletpowerup == true)
        {
            damage++;
        }

        // stop increasing the damage 
        if (damage >=3)
        {
            damage = 2;
        }
    }
}
