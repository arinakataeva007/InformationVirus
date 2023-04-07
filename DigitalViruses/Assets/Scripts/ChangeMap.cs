using UnityEngine;
using Random = UnityEngine.Random;

public class ChangeMap : MonoBehaviour
{
    [SerializeField] private GameObject point;
    [SerializeField] private Transform parent;

    private GameObject _northAmericaPoint;
    private GameObject _southAmericaPoint;
    private GameObject _greenLandPoint;
    private GameObject _iceLandPoint;
    private GameObject _africaPoint;
    private GameObject _russiaPoint;
    private GameObject _japanPoint;
    private GameObject _australiaPoint;


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

    private void Update()
    {
        DeletePoints();
    }

    private void CreatePoints()
    {
        InstantiateNorthAmerica();
        InstantiateSouthAmerica();
        InstantiateGreenLand();
        InstantiateIceLand();
        InstantiateAfrica();
        InstantiateRussia();
        InstantiateJapan();
        InstantiateAustralia();
    }

    private void DeletePoints()
    {
        if (parent.transform.childCount <= 0) 
            return;
        
        var randomIndex = Random.Range(0, parent.transform.childCount);
        Destroy(parent.transform.GetChild(randomIndex).gameObject);
    }
    
    private void InstantiateNorthAmerica()
    {
        for (var i = 0; i < pointCountNorthAmerica; i++)
        {
            _northAmericaPoint = Instantiate(point, 
                new Vector3(Random.Range(-9f, -4.25f), Random.Range(0f, 5.3f)), 
                Quaternion.identity);
            _northAmericaPoint.transform.parent = parent;
        }
    }
    
    private void InstantiateSouthAmerica()
    {
        for (var i = 0; i < pointCountSouthAmerica; i++)
        {    _southAmericaPoint = Instantiate(point, 
                new Vector3(Random.Range(-5.80f, -3f), Random.Range(0f, -4.60f)), 
                Quaternion.identity);        
            _southAmericaPoint.transform.parent = parent;
        }
    }
    
    private void InstantiateGreenLand()
    {
        for (var i = 0; i < pointCountGreenLand; i++)
        {
            _greenLandPoint = Instantiate(point,
                new Vector3(Random.Range(-4.36f, -2.27f), Random.Range(3.28f, 5.30f)),
                Quaternion.identity);
            _greenLandPoint.transform.parent = parent;
        }
    }
    
    private void InstantiateIceLand()
    {
        for (var i = 0; i < pointCountIceLand; i++)
        {
            _iceLandPoint = Instantiate(point,
                new Vector3(Random.Range(-2.40f, -1.85f), Random.Range(3.80f, 4.25f)),
                Quaternion.identity);
            _iceLandPoint.transform.parent = parent;
        }
    }
    
    private void InstantiateAfrica()
    {
        for (var i = 0; i < pointCountAfrica; i++)
        {
            _africaPoint = Instantiate(point,
                new Vector3(Random.Range(-2.15f, 2.10f), Random.Range(-3f, 1f)),
                Quaternion.identity);
            _africaPoint.transform.parent = parent;
        }
    }
    
    private void InstantiateRussia()
    {
        for (var i = 0; i < pointCountRussia; i++)
        {
            _russiaPoint = Instantiate(point,
                new Vector3(Random.Range(-1.65f, 9.45f), Random.Range(1f, 5.30f)),
                Quaternion.identity);
            _russiaPoint.transform.parent = parent;
        }
    }
    
    private void InstantiateJapan()
    {
        for (var i = 0; i < pointCountJapan; i++)
        {
            _japanPoint = Instantiate(point,
                new Vector3(Random.Range(4.23f, 6f), Random.Range(-1.5f, 1f)),
                Quaternion.identity);
            _japanPoint.transform.parent = parent;
        }
    }
    
    private void InstantiateAustralia()
    {
        for (var i = 0; i < pointCountAustralia; i++)
        {
            _australiaPoint = Instantiate(point,
                new Vector3(Random.Range(5.40f, 7.60f), Random.Range(-3.80f, -1.50f)),
                Quaternion.identity);
            _australiaPoint.transform.parent = parent;
        }
    }
}