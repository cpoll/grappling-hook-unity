using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour
{

    public GameObject sphereToSpawn;
    public int numberOfSpheres;

    Vector3 GetPosition() {
        // hardcoding the bounding box for spheres
        return new Vector3(
            Random.Range(-40, 40),
            Random.Range(10, 100),
            Random.Range(-40, 40)
        );
    }

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberOfSpheres; i++) {
            Instantiate(sphereToSpawn, GetPosition(), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
