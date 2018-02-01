using UnityEngine;

public class TestPathFinding : MonoBehaviour {

    [Range(0, 0.5f)]
    public float speed;
    public Hero hero;

    // Use this for initialization
    void Start ()
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
        transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
    }
}
