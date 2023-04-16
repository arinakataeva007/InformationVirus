using System;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private Text moneyText;
    public static int Money;

    private void Start()
    {
        Money = 90;
    }

    private void Update()
    {
        moneyText.text = $"Malware Coins: {Money}";
        
    }
}
