using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public float LoadAfter;
    void Start()
    {
        Invoke("LoadStartMenu",LoadAfter);
    }
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("01 Start Menu");
    }
   
}
