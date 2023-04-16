using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject keylogger;
    [SerializeField] private GameObject rootkit;
    
    [SerializeField] private float time = 5f;
    
    public void Exit() => Application.Quit();

    private void Start()
    {
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
}
