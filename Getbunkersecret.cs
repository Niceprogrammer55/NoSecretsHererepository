using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getbunkersecret : MonoBehaviour
{
    public bool gotbunkersecret;
    public LayerMask Playerlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gotbunkersecret = Physics.CheckSphere(transform.position,4f,Playerlayer);
        if(gotbunkersecret && GameObject.Find("Player").GetComponent<Secretmanager>().gotteleportsecret == 1){
            GameObject.Find("Player").GetComponent<Secretmanager>().gotteleportsecret = 0;
             GameObject.Find("Player").GetComponent<Secretmanager>().getsecrettext();
    }
    }
}
