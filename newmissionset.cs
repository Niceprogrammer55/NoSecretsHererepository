using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newmissionset : MonoBehaviour
{
    public bool Inrange;
    public float range;
    public LayerMask Playerlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inrange = Physics.CheckSphere(transform.position, range, Playerlayer);
        if(Inrange){
            
        }
    }
}
