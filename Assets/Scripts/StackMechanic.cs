using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackMechanic : MonoBehaviour
{
    [SerializeField]
    private float distanceBetweenObjects=1.0f;
    [SerializeField]
    private Transform parent;
    public Vector3 boxPosition;
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
        
        if (other.gameObject.tag == "Box")
        {
            TotalBoxCollected.instance.Value++;
            Stack(other.gameObject);
            Debug.Log("collision");
        }
    }

    public void Stack(GameObject stackedObject)
    {
        boxPosition = parent.position;
        stackedObject.transform.parent = parent;
        boxPosition.y += distanceBetweenObjects* TotalBoxCollected.instance.Value;
        stackedObject.transform.position= boxPosition;
        
    }
}
