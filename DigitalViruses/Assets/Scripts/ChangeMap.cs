using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Country
{
    public string Name { get; }
    public int PointCount { get; }
    
    public Vector3 Coordinate { get; set; }

    public (float, float) X, Y;

    public Country(string name, int pointCount, (float, float) x, (float, float) y)
    {
        Name = name;
        PointCount = pointCount;
        X = x;
        Y = y;
    }

    public Vector3 GetRandomCoordinate()
    {
        return new Vector3(Random.Range(X.Item1, X.Item2), Random.Range(Y.Item1, Y.Item2));
    }
}

public class ChangeMap : MonoBehaviour
{
    [SerializeField] private GameObject point;
    [SerializeField] private Transform parent;

    private GameObject _point;

    [Header("Количество точек")] 
    [SerializeField] private int pointCountNorthAmerica = 2000;
    [SerializeField] private int pointCountSouthAmerica = 1500;
    [SerializeField] private int pointCountGreenLand = 600;
    [SerializeField] private int pointCountIceLand = 100;
    [SerializeField] private int pointCountAfrica = 1000;
    [SerializeField] private int pointCountRussia = 2000;
    [SerializeField] private int pointCountJapan = 600;
    [SerializeField] private int pointCountAustralia = 600;

    private void Start()
    {
        CreatePoints();
    }

    private void FixedUpdate()
    {
        DeletePoints();
    }
    

    private void CreatePoints()
    {
        var countries = new List<Country>
        {
            new ("NorthAmerica", pointCountNorthAmerica, 
                (-9f, -4.25f), (0f, 5.3f)),
            
            new ("SouthAmerica", pointCountSouthAmerica, 
                (-5.80f, -3f), (0f, -4.60f)),
            
            new ("SouthAmerica", pointCountSouthAmerica, 
                (-5.80f, -3f), (0f, -4.60f)),
            
            new ("GreenLand", pointCountGreenLand, 
                (-4.36f, -2.27f), (3.28f, 5.30f)),
            
            new ("IceLand", pointCountIceLand, 
                (-2.40f, -1.85f), (3.80f, 4.25f)),
            
            new ("Africa", pointCountAfrica, 
                (-2.15f, 2.10f), (-3f, 1f)),
            
            new ("Russia", pointCountRussia, 
                (-1.65f, 9.45f), (1f, 5.30f)),
            
            new ("Japan", pointCountJapan, 
                (4.23f, 6f), (-1.5f, 1f)),
            
            new ("Australia", pointCountAustralia, 
                (5.40f, 7.60f), (-3.80f, -1.50f)),
        };

        foreach (var country in countries)
        {
            InstantiatePoints(country);
        }
    }

    private void DeletePoints()
    {
        if (parent.childCount <= 0) 
            return;
        
        var randomIndex = Random.Range(0, parent.childCount);
        Destroy(parent.GetChild(randomIndex).gameObject);
    }
    
    private void InstantiatePoints(Country country)
    {
        for (var i = 0; i < country.PointCount; i++)
        {
            _point = Instantiate(point, 
                country.GetRandomCoordinate(), 
                Quaternion.identity);
            _point.transform.parent = parent;
        }
    }
}