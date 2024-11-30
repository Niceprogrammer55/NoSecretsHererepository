using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerbody;
    public Transform cam;
    public float Mousesensitivity = 1000;
    private float xrotation = -35;
    public bool canmovemouse;
    
    
    // Start is called before the first frame update
    void Start()
    {
        canmovemouse = false;
        Invoke("Activatemouse",5f);

        
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(canmovemouse){
        
        float MouseX = Input.GetAxis("Mouse X") * Mousesensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * Mousesensitivity * Time.deltaTime;
         playerbody.Rotate(Vector3.up * (MouseX / 3));
         xrotation -= MouseY / 3;
         xrotation = Mathf.Clamp(xrotation, -90,90);
         transform.localRotation = Quaternion.Euler(xrotation,0,0);
        }
    }
    void Activatemouse(){
        canmovemouse = true;
        xrotation = 0;
    }
}