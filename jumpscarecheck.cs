using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscarecheck : MonoBehaviour
{
    public GameObject rawimage;
    public GameObject videoplayer;
    // Start is called before the first frame update
    void Start()
    {
        videoplayer.SetActive(false);
        rawimage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collisioninfo){
        if (collisioninfo.collider.tag == "Player"){
           videoplayer.SetActive(true);
           rawimage.SetActive(true);
           Invoke("Playerreset",2.5f);

        }
    }
    public void Playerreset(){
        videoplayer.SetActive(false);
        rawimage.SetActive(false);
        GameObject.Find("Player").transform.position = new Vector3(241.1f,2.32f,303.37f);
        GameObject.Find("Player").GetComponent<Secretmanager>().gotmonstersecret = 0;
        GameObject.Find("Player").GetComponent<Secretmanager>().getsecrettext();
    }
}
