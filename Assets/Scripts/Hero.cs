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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 427e50dc7e5c5b05a6cf2517d1750092438f225b
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
<<<<<<< HEAD
=======
=======
    public Vector2 angle;
    
>>>>>>> c8a6bc3d15aff8941f711d89d91fe0dc50bdd3bd
>>>>>>> 427e50dc7e5c5b05a6cf2517d1750092438f225b

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
<<<<<<< HEAD
       // Debug.LogFormat("Heros hp:{0} Heros dmg:{1}", hp, damage);
        damageup();
        
=======
<<<<<<< HEAD
       // Debug.LogFormat("Heros hp:{0} Heros dmg:{1}", hp, damage);
        damageup();
        
=======

>>>>>>> c8a6bc3d15aff8941f711d89d91fe0dc50bdd3bd
>>>>>>> 427e50dc7e5c5b05a6cf2517d1750092438f225b
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
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.RightArrow) && Time.time > nextFire )
=======
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.RightArrow) && Time.time > nextFire )
=======
        if (Input.GetKeyDown(KeyCode.RightArrow) && Time.time > nextFire)
>>>>>>> c8a6bc3d15aff8941f711d89d91fe0dc50bdd3bd
>>>>>>> 427e50dc7e5c5b05a6cf2517d1750092438f225b
        {
            
            angle = transform.right;
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 427e50dc7e5c5b05a6cf2517d1750092438f225b
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);

        } 
         if (Input.GetKeyDown(KeyCode.LeftArrow) && Time.time > nextFire)
=======
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && Time.time > nextFire)
>>>>>>> c8a6bc3d15aff8941f711d89d91fe0dc50bdd3bd
        {
            angle = new Vector2(-1, 0); 
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
<<<<<<< HEAD
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);

=======
<<<<<<< HEAD
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);

=======
>>>>>>> c8a6bc3d15aff8941f711d89d91fe0dc50bdd3bd
>>>>>>> 427e50dc7e5c5b05a6cf2517d1750092438f225b
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time > nextFire)
        {
            angle = transform.up;
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            float vol = Random.Range(volLowRange, volHighRange);
            source.PlayOneShot(shootSound, vol);



        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && Time.time > nextFire)
        {
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
