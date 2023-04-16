using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Perks : MonoBehaviour
{
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject perksMenu;
    
    [SerializeField] private GameObject loseScreen;

    [SerializeField] private List<Button> perks;
    [SerializeField] private List<int> prices;

    private void Update()
    {
        CheckLose();
    }

    public void GetPerk(int buttonIndex)
    {
        if (Game.Money >= prices[buttonIndex])
        {
            perks[buttonIndex].interactable = false;
            Game.Money -= prices[buttonIndex];
        }
        else
            return;

        ChangeMap.N = 64;
        perksMenu.SetActive(false);
    }

    private void CheckLose()
    {
        if (perks.Where((b, i) => b.interactable && Game.Money >= prices[i]).Any())
            return;
        
        LoseGame();
    }

    private void LoseGame()
    {
        game.SetActive(false);
        perksMenu.SetActive(false);
        loseScreen.SetActive(true);
    }
}
