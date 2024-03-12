using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PreferencesManager
{
    public static float GetMusicVolume()
    {
        return PlayerPrefs.GetFloat("MusicVolume", 1);
    }

    public static float GetFootstepsVolume()
    {
        return PlayerPrefs.GetFloat("FootstepsVolume", 1);
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat("MasterVolume", 1);
    }

    public static void SetMusicVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("MusicVolume", soundLevel);
    }

    public static void SetFootstepsVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("Footsteps", soundLevel);
    }

    public static void SetMasterVolume(float soundLevel)
    {
        PlayerPrefs.SetFloat("MasterVolume", soundLevel);
    }

}
