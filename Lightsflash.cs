using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightsflash : MonoBehaviour
{
    public GameObject bluelight;
    public GameObject redlight;
    public bool blueon;
    public bool redon;
    // Start is called before the first frame update
    void Awake(){
        blueon = true;
        redon = false;
    }
    void Start()
    {
        redlight.SetActive(false);
        bluelight.SetActive(true);
        blueon = true;
        redon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(blueon){
            Invoke("activatered", 0.5f);
        }
        if(redon){
            Invoke("activateblue", 0.5f);
        }
    }
    void activatered(){
        redlight.SetActive(true);
            bluelight.SetActive(false);
            blueon = false;
            redon = true;
    }
    void activateblue(){
        redlight.SetActive(false);
            bluelight.SetActive(true);
            blueon = true;
            redon = false;
    }
}
