using UnityEngine;
using UnityEngine.AI;

public class TestPathFinding : MonoBehaviour {

    /// <summary>
    /// 
    /// </summary>
    public Transform victim;

    /// <summary>
    /// 
    /// </summary>
    private NavMeshAgent navComponent;

    // Use this for initialization
    void Start () {
        // 
        navComponent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        Herofinder();
    }

    void Herofinder()
    {
        
            navComponent.SetDestination(victim.position);
        
    }
}
