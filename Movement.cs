using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController Controller;
    public float speed = 10;
    Vector3 velocity;
    public float gravity = -5;
    public float grounddistance = 0.2f;
    public Transform GroundCheck;
    public Transform ceilingCheck;
    public LayerMask groundlayer;
    bool onground;
    public float jumpstrength;
    public bool canmovemouse;
    public GameObject audioplayer;
    public bool touchingceiling;
    // Start is called before the first frame update
    void Start()
    {
        canmovemouse = false;
        audioplayer.SetActive(false);
        Invoke("Activatemouse",5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(canmovemouse){
        onground = Physics.CheckSphere(GroundCheck.transform.position,grounddistance, groundlayer);
        touchingceiling = Physics.CheckSphere(ceilingCheck.transform.position,grounddistance, groundlayer);
        if(onground && velocity.y < 0){
            velocity.y = -2f;
        }
        
        if(onground && Input.GetKeyDown(KeyCode.Space)){
            velocity.y = Mathf.Sqrt(jumpstrength * -2f * gravity);
        }
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        if(Input.GetKey(KeyCode.LeftShift) && onground){
            

            speed = 45;
            
        }
        else{
            if(onground){

            
            speed = 20;
            }
        }
        
        
        Vector3 move = transform.right * X + transform.forward * Z;
        Controller.Move(move * speed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        Controller.Move(velocity * Time.deltaTime);
        }
        
    }
    void Activatemouse(){
        audioplayer.SetActive(true);
        canmovemouse = true;
    }
}
