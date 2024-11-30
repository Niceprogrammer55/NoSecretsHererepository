using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmusicshutoffscript : MonoBehaviour
{
    public bool inrange;
    public LayerMask PlayerLayer;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inrange = Physics.CheckSphere(transform.position, 3.5f, PlayerLayer);
        if (inrange){
            audio.volume = 0f;
            Invoke("winscreen", 5f);
        }
        else{
            audio.volume = 1f;
        }
    }
    void winscreen(){
        SceneManager.LoadScene("winscreen");
    }
}
