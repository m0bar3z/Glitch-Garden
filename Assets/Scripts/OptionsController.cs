using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OptionsController : MonoBehaviour
{
    public Slider VolumeSlider, DifficultySlider;
    public MusicPlayer musicmanager;


    public GameObject FillSlider;
    public Color currentcolor = Color.white; 
    void Start()
    {
        musicmanager = GameObject.FindObjectOfType<MusicPlayer>();
        VolumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        DifficultySlider.value = PlayerPrefsManager.GetDifficulty();
    }

    void Update()
    {
        musicmanager.ChangeVolume(VolumeSlider.value);
        ChangeSlidersColor();
    }
    
    public void ChangeSlidersColor()
    {

        float Gchannel = 255f / DifficultySlider.value;
        print("this is gchannel   " + Gchannel);
        float Bchannel = 255f / DifficultySlider.value;
        currentcolor.g = Gchannel;
        currentcolor.b = Bchannel;
        FillSlider.GetComponent<Image>().color = currentcolor;
    }
    
    public void SetDefaults()
    {
        DifficultySlider.value = 2f;
        VolumeSlider.value = 0.8f;
    }
    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
        PlayerPrefsManager.SetDifficulty(DifficultySlider.value);
        SceneManager.LoadScene("01 Start Menu");   
    }
}
