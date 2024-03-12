using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Slider musicSlider;
    public Slider masterSlider;
    public Slider footstepsSlider;

    // Start is called before the first frame update
    void Start()
    {
        PreferencesManager.GetMasterVolume();
        PreferencesManager.GetMusicVolume();
        PreferencesManager.GetFootstepsVolume();
    }

    public void ChangeSoundVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeSoundVolume(soundLevel);
    }

    public void ChangeMusicVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeMusicVolume(soundLevel);
    }

    public void ChangeFootstepsVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeFootstepsVolume(soundLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
