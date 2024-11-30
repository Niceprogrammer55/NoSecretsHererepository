using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Findkingsecret : MonoBehaviour
{
    public bool inrange;
    public float range;
    public LayerMask playerlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inrange = Physics.CheckSphere(transform.position, range, playerlayer);
        
        if (inrange && GameObject.Find("Player").GetComponent<Secretmanager>().gotkingssecret == 1){
            GameObject.Find("Player").GetComponent<Secretmanager>().getsecrettext();
            GameObject.Find("Player").GetComponent<Secretmanager>().gotkingssecret = 0;
        }
    }
}
