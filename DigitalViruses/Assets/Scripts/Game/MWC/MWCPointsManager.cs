using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class MWCPointsManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> mwcPoints;
    
    [SerializeField] private int time;
    
    private void Start()
    {
        foreach (var mwcPoint in mwcPoints)
            mwcPoint.SetActive(false);
        
        Invoke(nameof(ActivateRandomPoint), time);
    }

    private void ActivateRandomPoint()
    {
        var index = Random.Range(0, mwcPoints.Count);
        mwcPoints[index].SetActive(true);
        
        var activatedPoints = mwcPoints.Count(mwcPoint => mwcPoint.activeInHierarchy);
        if (activatedPoints > 2)
            mwcPoints[index].SetActive(false);
        
        Invoke(nameof(ActivateRandomPoint), time);
    }
}
