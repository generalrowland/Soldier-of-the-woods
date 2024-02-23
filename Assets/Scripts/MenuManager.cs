using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Slider musicSlider;
    public Slider masterSlider;

    // Start is called before the first frame update
    void Start()
    {
        PreferencesManager.GetMasterVolume();
        PreferencesManager.GetMusicVolume();
    }

    public void ChangeSoundVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeSoundVolume(soundLevel);
    }

    public void ChangeMusicVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeMusicVolume(soundLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
