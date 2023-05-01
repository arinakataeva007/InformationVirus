using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] public AudioSource audioSource;
    
    [SerializeField] private GameObject keylogger;
    [SerializeField] private GameObject rootkit;
    
    [SerializeField] private float time = 5f;

    private void Start()
    {
        audioSource.volume = PlayerPrefs.HasKey("VolumeSettingPreference")
            ? PlayerPrefs.GetFloat("VolumeSettingPreference") : 0.05f;
        
        Invoke(nameof(Rootkit), time);
    }
    
    private void Keylogger()
    {
        keylogger.SetActive(true);
        rootkit.SetActive(false);
        
        Invoke(nameof(Rootkit), time);
    }

    private void Rootkit()
    {
        keylogger.SetActive(false);
        rootkit.SetActive(true);
        
        Invoke(nameof(Keylogger), time);
    }
    
    public void Exit() => Application.Quit();
}
