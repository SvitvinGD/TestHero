using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Amunition;
using UnityEngine;

public class AmunitionModel : MonoBehaviour
{
    [SerializeField] private Amunition _amunition;
    [SerializeField] private bool isActivity;

    public Amunition Amunition
    {
        get => _amunition;
        set => _amunition = value;
    }

    private int rarityFactor;
    void Start()
    {
        isActivity = true;
        switch (_amunition.RarityAmunition)
        {
            case RarityAmunition.Usual: rarityFactor = 1; break;
            case RarityAmunition.Rare: rarityFactor = 2; break;
            case RarityAmunition.Epic: rarityFactor = 4; break;
            case RarityAmunition.Legendary: rarityFactor = 8; break;
        }

        switch (_amunition.TypeAmunition)
        {   
            case TypeAmunition.Helmet:
                _amunition.Attack = 0;
                _amunition.HitPoint = 5;
                _amunition.Armor = 5; 
                break;
            case TypeAmunition.Bracers:
                _amunition.Attack = 5;
                _amunition.HitPoint = 3;
                _amunition.Armor = 7; 
                break;
            case TypeAmunition.Leggins:
                _amunition.Attack = 0;
                _amunition.HitPoint = 7;
                _amunition.Armor = 3; 
                break;
            case TypeAmunition.Chest:
                _amunition.Attack = 0;
                _amunition.HitPoint = 10;
                _amunition.Armor = 10; 
                break;
            case TypeAmunition.Sword:
                _amunition.Attack = 15;
                _amunition.HitPoint = 0;
                _amunition.Armor = 0; 
                break;
            case TypeAmunition.Shield:
                _amunition.Attack = 3;
                _amunition.HitPoint = 0;
                _amunition.Armor = 10; 
                break;
        }
        _amunition.Attack *= rarityFactor;
        _amunition.HitPoint *= rarityFactor;
        _amunition.Armor *= rarityFactor;
    }
}
