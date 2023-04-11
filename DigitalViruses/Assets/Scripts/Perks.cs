using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Perks : MonoBehaviour
{
    [SerializeField] private Text description;
    [SerializeField] private List<Toggle> toggles;

    public void ChangeDescription()
    {
        var currentToggle = EventSystem.current.currentSelectedGameObject.GetComponent<Toggle>();

        foreach (var toggle in toggles.Where(toggle => toggle != currentToggle))
            toggle.isOn = false;
        
        description.text = currentToggle.tag switch
        {
            "1" => "\nНазвание:\n" +
                   "Ввести двухэтапную аутентификацию" +
                   "\n\nСтоимость:\n" +
                   "???",
            
            "2" => "\nНазвание:\n" +
                   "Установить антивирус" +
                   "\n\nСтоимость:\n" +
                   "???",
            "3" => "\nНазвание:\n" +
                   "Обновить Софт" +
                   "\n\nСтоимость:\n" +
                   "???",
            
            "4" => "\nНазвание:\n" +
                   "Переустановить систему" +
                   "\n\nСтоимость:\n" +
                   "???",
            
            "5" => "\nНазвание:\n" +
                   "Поменять пароль" +
                   "\n\nСтоимость:\n" +
                   "???",
            
            _ => ""
        };
    }
}
