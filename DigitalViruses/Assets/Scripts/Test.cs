using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class Test : MonoBehaviour
{
    [SerializeField] private Button contiue;
    [SerializeField] private GameObject testsMenu;
    [SerializeField] private GameObject gameMenu;
    [SerializeField] private List<GameObject> tests;
    
    private List<int> _testCount = new List<int>() { 3, 2, 2, 3, 2 };

    private void Start()
    {
        tests[0].SetActive(true);
        contiue.interactable = false;
    }

    public void Right()
    {
        Game.Money += 10;
        contiue.interactable = true;
        
        _testCount[0]--;
    }

    public void Wrong()
    {
        Game.Money += 7;
        contiue.interactable = true;
        
        _testCount[0]--;
    }
    
    public void Continue()
    {
        Destroy(tests[0]);
        tests.RemoveAt(0);

        if (_testCount[0] > 0)
        {
            tests[0].SetActive(true);
            contiue.interactable = false;
        }
        else
        {
            _testCount.RemoveAt(0);
            
            testsMenu.SetActive(false);
            gameMenu.SetActive(true);
            
            tests[0].SetActive(true);
            Time.timeScale = 1f;
        }
            
    }
}