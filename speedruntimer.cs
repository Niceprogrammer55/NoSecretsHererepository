using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speedruntimer : MonoBehaviour
{
    public Text text;
    bool speedrunactivated = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("f") || speedrunactivated){
            speedrunactivated = true;
            text.text = Time.realtimeSinceStartup.ToString();
        }
    }
}
