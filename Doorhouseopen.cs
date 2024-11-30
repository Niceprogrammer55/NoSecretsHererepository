using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Doorhouseopen : MonoBehaviour
{
    private bool inrange;
    public float openrange;
    public LayerMask doorlayer;
    public Text text;
    public bool gothousekey;
    public Animator animationcontroller;
    public bool dooropened;
    // Start is called before the first frame update
    void Start()
    {
       dooropened = false;
    }

    // Update is called once per frame
    void Update()
    {
        inrange = Physics.CheckSphere(transform.position, openrange, doorlayer);
        if (inrange && gothousekey && !dooropened){
           text.text = "Press E to open the door";
           if(Input.GetKey("e")){
            GameObject.Find("Player").GetComponent<Secretmanager>().setofsecrets = 2;
            animationcontroller.SetBool("dooropening",true);
            dooropened = true;
           }
        }
        if (!inrange || dooropened){
            text.text = "";
        }
        if (inrange && !gothousekey){
            if(Input.GetKey("e")){
                text.text = "The door is locked";
            }
        }
    }
}
