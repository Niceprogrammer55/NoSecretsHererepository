using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memecubesecretfind : MonoBehaviour
{
    public bool gotmemecubesecret;
    public LayerMask Playerlayer;
    public bool secretalreadyfound;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gotmemecubesecret = Physics.CheckSphere(transform.position,40f,Playerlayer);
        if(gotmemecubesecret && GameObject.Find("Player").GetComponent<Secretmanager>().gotmemecubesecret == 1){
            GameObject.Find("Player").GetComponent<Secretmanager>().gotmemecubesecret = 0;
             GameObject.Find("Player").GetComponent<Secretmanager>().getsecrettext();
        }
        
    }
}
