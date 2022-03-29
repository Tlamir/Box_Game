using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject brokenBox;
    HingeJoint hingejoint;
    // Start is called before the first frame update
    void Start()
    {
        hingejoint=GetComponent<HingeJoint>();
        //hingejoint.connectedBody = null;

        
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
        if (other.gameObject.tag=="Player")
        {
            //gameObject.GetComponent<Rigidbody>().isKinematic = false;
            //hingejoint.connectedBody=other.GetComponent<Rigidbody>();
            //hingejoint.connectedAnchor= new Vector3(0, 0.6f, 0);
        }
    }
}
