using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 3.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed, 0, 0);
    }
}