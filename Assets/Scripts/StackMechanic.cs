using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackMechanic : MonoBehaviour
{
    [SerializeField]
    private float distanceBetweenObjects=1.0f;
    [SerializeField]
    private Transform parent;
    private GameObject prevBox;
    public Vector3 boxPosition;
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(TotalBoxCollected.instance.Value);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Box")
        {

            Stack(other.gameObject);       
            TotalBoxCollected.instance.Value++;
            Debug.Log("collision");
        }
    }

    public void Stack(GameObject stackedObject)
    {
        if (TotalBoxCollected.instance.Value==0)
        {
            //Fix code repeat later
            prevBox = stackedObject;
            boxPosition = parent.position;
            stackedObject.transform.parent = parent;
            boxPosition.y += distanceBetweenObjects;
            stackedObject.transform.position = boxPosition;
            stackedObject.GetComponent<HingeJoint>().connectedBody=GetComponent<Rigidbody>();
        }
        else
        {
            boxPosition = parent.position;
            stackedObject.transform.parent = parent;
            boxPosition.y += distanceBetweenObjects*(TotalBoxCollected.instance.Value+1);
            stackedObject.transform.position = boxPosition;
            stackedObject.GetComponent<HingeJoint>().connectedBody = prevBox.GetComponent<Rigidbody>();
            prevBox = stackedObject;

        }
       
        
    }
}
