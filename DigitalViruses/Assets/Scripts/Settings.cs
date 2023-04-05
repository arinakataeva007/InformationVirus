using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] public Dropdown resolutionDropdown;
    [SerializeField] public Dropdown qualityDropdown;
    [SerializeField] public Toggle toggle;
    
    private Resolution[] _resolutions;

    public void Start()
    {
        _resolutions = Screen.resolutions;
        var options = new string[_resolutions.Length];
        
        for (var i = 0; i < _resolutions.Length; i++)
            options[i] = _resolutions[i].width +
                         "x" + _resolutions[i].height + " " +
                         _resolutions[i].refreshRate + "Hz";
        
        resolutionDropdown.ClearOptions();
        resolutionDropdown.AddOptions(options.ToList());
        resolutionDropdown.RefreshShownValue();
        
        LoadSettings();
    }

    private void LoadSettings()
    {
        qualityDropdown.value = PlayerPrefs.HasKey("QualitySettingPreference") 
            ? PlayerPrefs.GetInt("QualitySettingPreference") : 3;
        
        resolutionDropdown.value = PlayerPrefs.HasKey("ResolutionPreference") 
            ? PlayerPrefs.GetInt("ResolutionPreference") : _resolutions.Length;

        Screen.fullScreen = !PlayerPrefs.HasKey("FullscreenPreference") 
                            || Convert.ToBoolean(PlayerPrefs.GetInt("FullscreenPreference"));
        toggle.isOn = Screen.fullScreen;
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        var resolution = _resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("QualitySettingPreference", qualityDropdown.value);
        PlayerPrefs.SetInt("ResolutionPreference", resolutionDropdown.value);
        PlayerPrefs.SetInt("FullscreenPreference", Convert.ToInt32(Screen.fullScreen));
    }
}
