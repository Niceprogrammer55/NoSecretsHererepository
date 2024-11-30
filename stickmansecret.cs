using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickmansecret : MonoBehaviour
{
    public float range;
    public bool inrange;
    public LayerMask PlayerLayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inrange = Physics.CheckSphere(transform.position,range,PlayerLayer);
        if(inrange && GameObject.Find("Player").GetComponent<Secretmanager>().gotstickmanguysecret == 1){
            GameObject.Find("Player").GetComponent<Secretmanager>().gotstickmanguysecret = 0;
            GameObject.Find("Player").GetComponent<Secretmanager>().getsecrettext();
        }
    }
}
