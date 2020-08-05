using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ShowDiffNumber : MonoBehaviour
{
    public Text text;
    public Slider DifficultySlider;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = DifficultySlider.value.ToString();
        
    }
}
