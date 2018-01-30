using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour {

    public GameObject needlePrefab;
    public GameObject Hero;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnNeedle(Hero.transform.position);
        }
	}

    GameObject SpawnNeedle(Vector3 position)
    {
        if (needlePrefab == null)
        {
            Debug.LogErrorFormat("No prefab reference set.");
            return null;
        }

        //instantiate needle
        GameObject needle = Instantiate(needlePrefab, position, Quaternion.identity);

        // parent to this transform
        needle.transform.parent = transform;
        return needle;
    }
}
