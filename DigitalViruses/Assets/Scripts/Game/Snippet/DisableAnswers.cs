using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableAnswers : MonoBehaviour
{
    [SerializeField] private List<Button> answers;
    
    public void Disable()
    {
        foreach (var answer in answers)
        {
            answer.interactable = false;
        }
    }
}
