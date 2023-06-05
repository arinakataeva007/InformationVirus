using System;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private Text moneyText;
    [SerializeField] private AudioSource audioSource;
    public static int Money;

    private void Start()
    {
        Money = 30;
        
        audioSource.volume = PlayerPrefs.HasKey("VolumeSettingPreference")
            ? PlayerPrefs.GetFloat("VolumeSettingPreference") : 0.05f;
    }

    private void Update()
    {
        moneyText.text = $"Malware Coins: {Money}";
        
    }
}
