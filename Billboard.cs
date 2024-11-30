using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(GameObject.Find("Main Camera").transform);
        transform.Rotate(0, 180, 0);
      Vector3 newRotation = GameObject.Find("Main Camera").transform.eulerAngles;

    newRotation.x = 0;
    newRotation.z = 0;

    transform.eulerAngles = newRotation;
        
        
        
    }
}
