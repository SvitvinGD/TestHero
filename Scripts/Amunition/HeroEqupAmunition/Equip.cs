using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Amunition;
using UnityEngine;

public class Equip : MonoBehaviour
{
    [SerializeField] private CellInfoController _cellInfoController;
    [SerializeField] private EquipAmunitonController _equipAmunitonController;
    private AmunitionModel temp;

    public void EquipAmunitionHero()
    {
        Debug.Log("Equip");
        switch (_cellInfoController.CellController.AmunitionModel.Amunition.TypeAmunition)
        {
            case TypeAmunition.Helmet:
                temp = _equipAmunitonController.Helmet.AmunitionModel;
                _equipAmunitonController.Helmet.AmunitionModel = _cellInfoController.CellController.AmunitionModel;
                break;
            case TypeAmunition.Shield:
                temp = _equipAmunitonController.Shield.AmunitionModel;
                _equipAmunitonController.Shield.AmunitionModel = _cellInfoController.CellController.AmunitionModel;
                break;
            case TypeAmunition.Sword:
                temp = _equipAmunitonController.Sword.AmunitionModel;
                _equipAmunitonController.Sword.AmunitionModel = _cellInfoController.CellController.AmunitionModel;
                break;
            case TypeAmunition.Leggins:
                temp = _equipAmunitonController.Leggings.AmunitionModel;
                _equipAmunitonController.Leggings.AmunitionModel = _cellInfoController.CellController.AmunitionModel;
                break;
            case TypeAmunition.Chest:
                temp = _equipAmunitonController.Chest.AmunitionModel;
                _equipAmunitonController.Chest.AmunitionModel = _cellInfoController.CellController.AmunitionModel;
                break;
            case TypeAmunition.Bracers:
                temp = _equipAmunitonController.Bracers.AmunitionModel;
                _equipAmunitonController.Bracers.AmunitionModel = _cellInfoController.CellController.AmunitionModel;
                break;
        }
        _cellInfoController.CellController.AmunitionModel = temp;
        //_cellInfoController.CellController.IsEmpty = true;
    }
}
