using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headsecretfindscript : MonoBehaviour
{
    public bool gotheadsecret;
    public LayerMask Playerlayer;
    public bool secretalreadyfound;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gotheadsecret = Physics.CheckSphere(transform.position,100f,Playerlayer);
        if(gotheadsecret && GameObject.Find("Player").GetComponent<Secretmanager>().gotheadsecret2 == false){
            GameObject.Find("Player").GetComponent<Secretmanager>().gotheadsecret2 = true;
             GameObject.Find("Player").GetComponent<Secretmanager>().getsecrettext();
        }
        
    }
}
