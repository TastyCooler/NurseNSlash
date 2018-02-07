using UnityEngine;

public class TestPathFinding : MonoBehaviour
{

    [Range(0, 0.5f)]
    public float maxspeed;
    public Hero hero;

    // Use this for initialization
    void Start()
    {
        hero = FindObjectOfType<Hero>();
    }

    void Update()
    {
        Find();
    }

    void Find()
    {

        Vector3 localPosition = hero.transform.position - transform.position;
        localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        transform.Translate(localPosition.x * Time.deltaTime * Random.Range(0.1f, maxspeed), localPosition.y * Time.deltaTime * Random.Range(0.1f, maxspeed), localPosition.z * Time.deltaTime * maxspeed);
    }
}
