using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject brokenBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Obstacle")
        {
            Instantiate(brokenBox, transform.position, transform.rotation); 
            Destroy(this.gameObject);
            TotalBoxCollected.instance.Value--;
        }
    }
}
