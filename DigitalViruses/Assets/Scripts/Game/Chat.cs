using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Chat : MonoBehaviour
{
    [SerializeField] private GameObject chat;
    [SerializeField] private GameObject test;
    [SerializeField] private List<GameObject> chats;
    [SerializeField] private List<GameObject> answers;

    private int _answerCount;

    private void Start()
    {
        chats[0].SetActive(true);
        answers[0].SetActive(true);
    }

    public void Answer()
    {
        Destroy(answers[0]);
        answers.RemoveAt(0);

        _answerCount++;
        
        switch (_answerCount)
        {
            case < 4:
                answers[0].SetActive(true);
                break;
            
            case 4:
                _answerCount = 0;
            
                Destroy(chats[0]);
                chats.RemoveAt(0);

                if (chats.Count > 0)
                {
                    chats[0].SetActive(true);
                    answers[0].SetActive(true);
                }

                chat.SetActive(false);
                test.SetActive(true);
                
                break;
        }
    }
}
