using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CellMarketController : MonoBehaviour
{
    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private CellController _cellController;
    [SerializeField] private TextMeshProUGUI statistic;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private bool isEmpty;

    public RectTransform RectTransform
    {
        get => _rectTransform;
        set => _rectTransform = value;
    }

    public CellController CellController
    {
        get => _cellController;
        set => _cellController = value;
    }

    public TextMeshProUGUI Statistic
    {
        get => statistic;
        set => statistic = value;
    }

    public TextMeshProUGUI Name
    {
        get => name;
        set => name = value;
    }

    public bool IsEmpty
    {
        get => isEmpty;
        set => isEmpty = value;
    }

    void Start()
    {
        if (_cellController.AmunitionModel == null)
        {
            isEmpty = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (_cellController.AmunitionModel == null)
        {
            isEmpty = true;
        }
        if (_cellController.AmunitionModel != null)
        {
            var amunition = _cellController.AmunitionModel.Amunition;
            name.text = amunition.name;
            statistic.text = "Attack: " +amunition.Attack+ "\nHit Point: " + amunition.HitPoint +"\nArmor: " + amunition.Armor;
        }

    }
}
