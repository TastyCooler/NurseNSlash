using UnityEngine;

public class TestPathFinding : MonoBehaviour {

    [Range(0, 0.5f)]
    public float speed;
    public GameObject player;

    // Use this for initialization
    void Start ()
    {

    }

    void Update()
    {
        Find();
    }

    void Find()
    {
        Vector3 localPosition = player.transform.position - transform.position;
        localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
    }
}
