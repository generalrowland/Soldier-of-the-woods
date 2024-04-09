using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    public static AudioManager Instance {  get { return instance; } }

    public AudioMixer masterMixer;

    public void Awake()
    {
       if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        } 
       else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        masterMixer.SetFloat("MasterVol", PreferencesManager.GetMasterVolume());
        masterMixer.SetFloat("MusicVol", PreferencesManager.GetMusicVolume());
        masterMixer.SetFloat("FootstepsVol", PreferencesManager.GetFootstepsVolume());
    }

    public void ChangeSoundVolume(float soundLevel)
    {
        masterMixer.SetFloat("MasterVol", soundLevel);
        PreferencesManager.SetMasterVolume(soundLevel);
    }

    public void ChangeMusicVolume(float soundLevel)
    {
        masterMixer.SetFloat("MusicVol", soundLevel);
        PreferencesManager.SetMusicVolume(soundLevel);
    }

    public void ChangeFootstepsVolume(float soundLevel)
    {
        masterMixer.SetFloat("FootstepsVol", soundLevel);
        PreferencesManager.SetFootstepsVolume(soundLevel);
    }
}
