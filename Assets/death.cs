using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnCollisionEnter2D is called when a collision occurs
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroy the object that collides with this object
        Destroy(collision.gameObject);
    }
}
