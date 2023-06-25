using UnityEngine;
using UnityEngine.EventSystems;

public class MWCPoint : MonoBehaviour
{
    [SerializeField] private int moneyToAdd;
    private GameObject _button;

    public void AddMoney() => Invoke(nameof(Deactivate), 0.2f);

    private void Deactivate()
    {
        Game.Money += moneyToAdd;
        _button = EventSystem.current.currentSelectedGameObject;
        
        _button.SetActive(false);
    }
}
