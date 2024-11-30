using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appearscript : MonoBehaviour
{
    public GameObject self;
    // Start is called before the first frame update
    void Start()
    {
        self.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Player").GetComponent<teleportcutsceneactivate>().teleported == true){
            Invoke("appear",2.30f);
        }
    }
    void appear(){
              self.SetActive(GameObject.Find("Player").GetComponent<teleportcutsceneactivate>().teleported);
    }
}
