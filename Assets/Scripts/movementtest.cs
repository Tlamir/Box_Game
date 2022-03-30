using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementtest : MonoBehaviour
{
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 5f);
        }

        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 5f);
        }
    }
}
