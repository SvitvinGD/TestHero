using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Amunition;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipCell : MonoBehaviour
{
    [SerializeField] private CellController _cellController;
    [SerializeField] private TypeAmunition _typeAmunition;
    [SerializeField] private AmunitionModel _amunitionModel;
    [SerializeField] private int attack;
    [SerializeField] private int hitPoint;
    [SerializeField] private int armor;
    [SerializeField] private bool isEmpty;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private Image _image;

    public CellController CellController
    {
        get => _cellController;
        set => _cellController = value;
    }

    public TypeAmunition TypeAmunition
    {
        get => _typeAmunition;
        set => _typeAmunition = value;
    }

    public AmunitionModel AmunitionModel
    {
        get => _amunitionModel;
        set => _amunitionModel = value;
    }

    public int Attack
    {
        get => attack;
        set => attack = value;
    }

    public int HitPoint
    {
        get => hitPoint;
        set => hitPoint = value;
    }

    public int Armor
    {
        get => armor;
        set => armor = value;
    }

    public bool IsEmpty
    {
        get => isEmpty;
        set => isEmpty = value;
    }

    public TextMeshProUGUI Name
    {
        get => name;
        set => name = value;
    }

    public Image Image
    {
        get => _image;
        set => _image = value;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        _cellController.AmunitionModel = _amunitionModel;
        if (_amunitionModel == null)
            isEmpty = true;
        else
            isEmpty = false;
        if (isEmpty)
        {
            name.text = "" + getNameAmunition();
            _image.color = new Color(0.6862f, 0.6862f, 0.6862f, 1);
        }
        else
        {
            attack = _amunitionModel.Amunition.Attack;
            hitPoint = _amunitionModel.Amunition.HitPoint;
            armor = _amunitionModel.Amunition.Armor;
            name.text = "";
            _image.color = new Color(1, 1, 1, 1);
            _image.sprite = _amunitionModel.Amunition.Sprite;

        }
    }

    private string getNameAmunition()
    {
        return _typeAmunition.ToString();
    }
}
