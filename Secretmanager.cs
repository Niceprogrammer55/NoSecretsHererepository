using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Secretmanager : MonoBehaviour
{
    public bool gotheadsecret2;
    public Text Getheadsecrettext;
    public int secretsneeded1;
    public int gotheadsecret;
    public int gotmonstersecret;
    public int gotteleportsecret;
    public int setofsecrets = 1;
    public int gotheadsstaringathousesecret;
    public Text Objective;
    public int gotstickmanguysecret;
    public int gotmemecubesecret = 1;
    public int gotstickmanbeersecret = 1;
    public int gotkingssecret = 1;
    public int gotcarsecret = 1;
    public int gotemptycarandheadandstickmansecret = 1;
    
    // Start is called before the first frame update
    void Start()
    {
      gotheadsecret2 = false;  
      Getheadsecrettext.text = " ";
      gotmonstersecret = 1;
      gotteleportsecret = 1;
      gotheadsecret = 1;
      gotheadsstaringathousesecret = 1;
      gotstickmanguysecret = 1;
      gotcarsecret = 1;
    }

    // Update is called once per frame
    void Update()
    {
        secretsneeded1 = gotemptycarandheadandstickmansecret + gotcarsecret + gotkingssecret + gotheadsecret + gotstickmanbeersecret + gotmemecubesecret + gotmonstersecret + gotteleportsecret + gotheadsstaringathousesecret + gotstickmanguysecret;
         if(gotheadsecret2){
            gotheadsecret = 0;
         }
         
        if(secretsneeded1 == 1 && setofsecrets == 1){
        Objective.text = "Find " + secretsneeded1 + " secret";
        }
        else{
            if(setofsecrets == 1){
        Objective.text = "Find " + secretsneeded1 + " secrets";
            }
        }
        if(secretsneeded1 == 0 && setofsecrets == 1){
            Objective.text = "You recieved a key for your hard work";
            GameObject.Find("Player").GetComponent<Doorhouseopen>().gothousekey = true;
        }


        
    }
    public void getsecrettext(){
        Getheadsecrettext.text = "You found a secret!";
        Invoke("Resetsecrettext",2);
        
    }
    public void Resetsecrettext(){
        Getheadsecrettext.text = " ";
    }
}
