using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    [SerializeField] private string name;
    [SerializeField] private int level;
    [SerializeField] private int attack;
    [SerializeField] private int hitPoint;
    [SerializeField] private int armor;
    [SerializeField] private EquipAmunitonController _equipAmunitonController;

    public int Level
    {
        get => level;
        set => level = value;
    }

    public string Name
    {
        get => name;
        set => name = value;
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attack = _equipAmunitonController.Attack;
        hitPoint = _equipAmunitonController.HitPoint;
        armor = _equipAmunitonController.Armor;
    }
}
