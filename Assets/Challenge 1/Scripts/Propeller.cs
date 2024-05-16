using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Propeller : MonoBehaviour
{   
    public int Speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( Vector3.forward * Time.deltaTime * Speed);
    }
}
