using System.Collections.Generic;
using UnityEngine;

public class Virezka : MonoBehaviour
{
    [SerializeField] private List<GameObject> virezki;
    [SerializeField] private GameObject virezka;
    
    private void Start()
    {
        virezki[0].SetActive(true);
        Time.timeScale = 0f;
    }

    public void Continue()
    {
        Destroy(virezki[0]);
        virezki.RemoveAt(0);
        
        virezki[0].SetActive(true);
        virezka.SetActive(false);
    }
}
