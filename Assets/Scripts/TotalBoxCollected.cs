using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalBoxCollected : MonoBehaviour
{
    public static TotalBoxCollected instance { get; private set; }
    public int Value;

    private void Awake()
    {
        if (instance==null)
        {   
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
