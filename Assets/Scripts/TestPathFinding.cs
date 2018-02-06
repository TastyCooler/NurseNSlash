using UnityEngine;

public class TestPathFinding : MonoBehaviour
{

    [Range(0, 0.5f)]
<<<<<<< HEAD
    public float maxspeed;
=======
    public float speed;
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> c8a6bc3d15aff8941f711d89d91fe0dc50bdd3bd
    public Hero hero;
=======
    public GameObject player;
>>>>>>> af9196f8b15bdaae14b3aac8655d989f9a754c4d
=======
    public GameObject player;
>>>>>>> af9196f8b15bdaae14b3aac8655d989f9a754c4d

    // Use this for initialization
    void Start()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        hero = FindObjectOfType<Hero>();
=======

>>>>>>> af9196f8b15bdaae14b3aac8655d989f9a754c4d
=======

>>>>>>> af9196f8b15bdaae14b3aac8655d989f9a754c4d
    }

    void Update()
    {
        Find();
    }

    void Find()
    {
<<<<<<< HEAD

=======
<<<<<<< HEAD
<<<<<<< HEAD
        
>>>>>>> c8a6bc3d15aff8941f711d89d91fe0dc50bdd3bd
        Vector3 localPosition = hero.transform.position - transform.position;
=======
        Vector3 localPosition = player.transform.position - transform.position;
>>>>>>> af9196f8b15bdaae14b3aac8655d989f9a754c4d
=======
        Vector3 localPosition = player.transform.position - transform.position;
>>>>>>> af9196f8b15bdaae14b3aac8655d989f9a754c4d
        localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        transform.Translate(localPosition.x * Time.deltaTime * Random.Range(0.1f, maxspeed), localPosition.y * Time.deltaTime * Random.Range(0.1f, maxspeed), localPosition.z * Time.deltaTime * maxspeed);
    }
}
