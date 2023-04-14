using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private Text moneyText;
    public static int Money = 10000;
    
    private void Update()
    {
        moneyText.text = $"Cyber Coins: {Money}";
    }
}
