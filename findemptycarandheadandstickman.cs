using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findemptycarandheadandstickman : MonoBehaviour
{
    public LayerMask playerlayer;
    public float range;
    public bool inrange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inrange = Physics.CheckSphere(transform.position, range, playerlayer);
        if(inrange && GameObject.Find("Player").GetComponent<Secretmanager>().gotemptycarandheadandstickmansecret == 1){
            GameObject.Find("Player").GetComponent<Secretmanager>().gotemptycarandheadandstickmansecret = 0;
            GameObject.Find("Player").GetComponent<Secretmanager>().getsecrettext();
        }
    }
}
