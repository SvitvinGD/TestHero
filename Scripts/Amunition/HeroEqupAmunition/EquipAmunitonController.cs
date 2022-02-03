using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Amunition;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class EquipAmunitonController : MonoBehaviour
{
    [SerializeField] private EquipCell helmet;
    [SerializeField] private EquipCell sword;
    [SerializeField] private EquipCell shield;
    [SerializeField] private EquipCell chest;
    [SerializeField] private EquipCell bracers;
    [SerializeField] private EquipCell leggings;
    [SerializeField] private int attack;
    [SerializeField] private int hitPoint;
    [SerializeField] private int armor;

    public EquipCell Helmet
    {
        get => helmet;
        set => helmet = value;
    }

    public EquipCell Sword
    {
        get => sword;
        set => sword = value;
    }

    public EquipCell Shield
    {
        get => shield;
        set => shield = value;
    }

    public EquipCell Chest
    {
        get => chest;
        set => chest = value;
    }

    public EquipCell Bracers
    {
        get => bracers;
        set => bracers = value;
    }

    public EquipCell Leggings
    {
        get => leggings;
        set => leggings = value;
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
        attack = helmet.Attack + chest.Attack + shield.Attack + bracers.Attack + leggings.Attack + sword.Attack;
        hitPoint = helmet.HitPoint + chest.HitPoint + shield.HitPoint + bracers.HitPoint + leggings.HitPoint + sword.HitPoint;
        armor = helmet.Armor + chest.Armor + shield.Armor + bracers.Armor + leggings.Armor + sword.Armor;
    }
    
}
