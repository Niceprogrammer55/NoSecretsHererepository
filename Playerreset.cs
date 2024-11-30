using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerreset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player").transform.position.y <= -85f){
            GameObject.Find("Player").transform.position = new Vector3(241.1f,2.32f,303.37f);
        }
    }
    
    
}
