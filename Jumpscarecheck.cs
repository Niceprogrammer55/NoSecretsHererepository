using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jumpscarecheck : MonoBehaviour
{
    public GameObject videoplayer;
    public GameObject Rawimage;
    public Transform self;
    public Transform resetpoint;
    public float range;
    public bool inrange;
    public LayerMask Monsterlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoplayer.SetActive(false);
        Rawimage.SetActive(false);
        self.transform.position = new Vector3(389.1f,2.32f,304.5f);
    }

    // Update is called once per frame
    void Update()
    {
        inrange = Physics.CheckSphere(transform.position, range * 2, Monsterlayer);
        if (inrange){
            self.transform.position = new Vector3(0,0,0);
            videoplayer.SetActive(true);
            Rawimage.SetActive(true);
            
            self.transform.position = new Vector3(389.1f,2.32f,304.5f);
            self.transform.position = resetpoint.transform.position;
            Invoke("Reset", 3);
            Debug.Log("cool2");
        }
    }
    
    void Reset(){
        Debug.Log("cool3");
        self.transform.position = new Vector3(389.1f,2.32f,304.5f);
        self.transform.position = resetpoint.transform.position;
        videoplayer.SetActive(false);
        Rawimage.SetActive(false);
    }
}
