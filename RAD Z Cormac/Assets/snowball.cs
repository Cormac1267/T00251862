using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowball : MonoBehaviour
{
    Rigidbody rb;
    internal void throwSnowball(Transform thrower)
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
            print("Found Rigid Body");
        else
            print("could not find Rigid Body");
        rb.AddExplosionForce(5000, thrower.position, 3);

    }
    
    void Start()
    {
        
    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        
    }
}
