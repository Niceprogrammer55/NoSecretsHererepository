using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonscript : MonoBehaviour
{
    public void onclick(){
        SceneManager.LoadScene("Game");
    }
}
