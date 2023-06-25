using System.Collections.Generic;
using UnityEngine;
using Button = UnityEngine.UI.Button;

public class Test : MonoBehaviour
{
    [SerializeField] private Button contiue;
    [SerializeField] private GameObject testsMenu;
    [SerializeField] private GameObject gameMenu;
    [SerializeField] private List<GameObject> tests;
    
    [SerializeField] private List<int> _testCount;

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
        Game.Money += 5;
        contiue.interactable = true;
        
        _testCount[0]--;
    }
    
    public void Continue()
    {
        Destroy(tests[0]);
        tests.RemoveAt(0);
        
        contiue.interactable = false;
        
        if (_testCount[0] > 0)
            tests[0].SetActive(true);

        else
        {
            _testCount.RemoveAt(0);
            
            testsMenu.SetActive(false);
            gameMenu.SetActive(true);
            
            if (tests.Count > 0)
                tests[0].SetActive(true);
            
            Time.timeScale = 1f;
        }
            
    }
}
