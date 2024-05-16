using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroi : MonoBehaviour
{
    public static DontDestroi instance;

    private void Start()
    {
        if(instance != null)
        {
            Destroy(gameObject);

        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        
    }
}