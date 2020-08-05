using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Fadepanel : MonoBehaviour
{
    public float FadiInTime;

    private Image FadeImage;
    
    private Color CurrentColor = Color.black;
    
   
    
    void Start()
    {
        FadeImage = GetComponent<Image>();
    }


    void Update()
    {
        if (Time.timeSinceLevelLoad < FadiInTime)
        {
            float AlphaChange = Time.deltaTime / FadiInTime;
               // FadeImage.
               CurrentColor.a -= AlphaChange;
               FadeImage.color = CurrentColor;    
        }
        else
        {
            gameObject.SetActive(false);
        }

}
}
