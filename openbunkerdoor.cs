using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openbunkerdoor : MonoBehaviour
{
    public bool inrange;
    public float range;
    public LayerMask PlayerLayer;
    public Animator animationcontroller;
    public Text text;
    public bool dooropened;
    // Start is called before the first frame update
    void Start()
    {
        dooropened = false;
    }

    // Update is called once per frame
    void Update()
    {
        inrange = Physics.CheckSphere(transform.position, range , PlayerLayer);
        if(inrange){
            text.text = "Press E to open the bunker door";
        }
        if(inrange && Input.GetKey("e")){
            
           animationcontroller.SetBool("Openeddoor",true);
           dooropened = true;
        }
        if (!inrange || dooropened){
            text.text = "";
        }
    }
}
