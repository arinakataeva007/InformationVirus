using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Perks : MonoBehaviour
{
    [SerializeField] private GameObject game;
    [SerializeField] private GameObject perksMenu;
    
    [SerializeField] private List<Button> perks;
    [SerializeField] private List<int> prices;

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

}
