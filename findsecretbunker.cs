using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findsecretbunker : MonoBehaviour
{
    public bool inrange;
    public float range;
    public LayerMask Playerlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inrange = Physics.CheckSphere(transform.position, range, Playerlayer);
        if (inrange){
            GameObject.Find("Player").GetComponent<Secretmanager>().getsecrettext();
            GameObject.Find("Player").GetComponent<Secretmanager>().gotteleportsecret = 0;
        }
    }
}
