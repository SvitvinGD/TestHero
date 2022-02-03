using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CellInfoController : MonoBehaviour
{
    [SerializeField] private CellController _cellController;
    [SerializeField] private TextMeshProUGUI statistic;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private Image image;
    [SerializeField] private Button buyButton;
    [SerializeField] private CellMarketController _cellMarketController;
    [SerializeField] private GridMarketController _gridMarketController;
    [SerializeField] private GridController _gridController;
    
     private UnityAction buy;

     public CellMarketController CellMarketController
     {
         get => _cellMarketController;
         set => _cellMarketController = value;
     }

     public CellController CellController
    {
        get => _cellController;
        set => _cellController = value;
    }

     void Start()
     {
         if (buyButton != null)
         {
             buy += BuyItem;
             buyButton.onClick.AddListener(buy);
         }
     }
    // Start is called before the first frame update
    void Update()
    {
        var amunition = _cellController.AmunitionModel.Amunition;
        name.text = amunition.name;
        image.sprite = amunition.Sprite;
        statistic.text = "Attack: " +amunition.Attack+ "\nHit Point: " + amunition.HitPoint +"\nArmor: " + amunition.Armor
                         +"\nRarity: " + amunition.RarityAmunition+"\nType: " + amunition.TypeAmunition;
        
    }

    void BuyItem()
    {
        if (_gridController.AddItem(_cellController.AmunitionModel))
        {
            Debug.Log("+");
            _gridMarketController.RemuveComponent(_cellMarketController);
        }
        else
        {
            Debug.Log("-");
        }
    }

    public void Close()
    {
        gameObject.active = false;
    }
}
