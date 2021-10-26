using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demoSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Instantiate(objectToSpawn, new Vector3(20, 12, 109), transform.rotation);
        }
    }
}
