using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxShatter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Rigidbody>().AddExplosionForce(500, transform.position, 5);
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
