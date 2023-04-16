using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject game;

    private void Update()
    {
        WinGame();
    }

    private void WinGame()
    {
        if (parent.childCount > 1)
            return;
        
        game.SetActive(false);
        winScreen.SetActive(true);
    }
}
