using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Amunition;
using UnityEngine;
using UnityEngine.UI;

public class Amunition : MonoBehaviour
{
    [SerializeField] private TypeAmunition _typeAmunition;
    [SerializeField] private RarityAmunition _rarityAmunition;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private int attack;
    [SerializeField] private int hitPoint;
    [SerializeField] private int armor;

    public TypeAmunition TypeAmunition
    {
        get => _typeAmunition;
        set => _typeAmunition = value;
    }

    public RarityAmunition RarityAmunition
    {
        get => _rarityAmunition;
        set => _rarityAmunition = value;
    }

    public Sprite Sprite
    {
        get => _sprite;
        set => _sprite = value;
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
}
