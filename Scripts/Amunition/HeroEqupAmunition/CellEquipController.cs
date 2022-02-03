using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Amunition;
using UnityEngine;

public class CellEquipController : MonoBehaviour
{

    [SerializeField] private EquipAmunitonController _equipAmunitonController;
    [SerializeField] private CellInfoController cellInfoController;
    public void CheckEqupItem(CellController cellController)
    {

        if (cellController.AmunitionModel != null)
        {
            cellInfoController.gameObject.active = true;
            switch (cellController.AmunitionModel.Amunition.TypeAmunition)
            {
                case TypeAmunition.Helmet:
                    cellInfoController.CellController = _equipAmunitonController.Helmet.CellController;
                    break;
                case TypeAmunition.Shield:
                    cellInfoController.CellController = _equipAmunitonController.Shield.CellController;
                    break;
                case TypeAmunition.Sword:
                    cellInfoController.CellController = _equipAmunitonController.Sword.CellController;
                    break;
                case TypeAmunition.Leggins:
                    cellInfoController.CellController = _equipAmunitonController.Leggings.CellController;
                    break;
                case TypeAmunition.Chest:
                    cellInfoController.CellController = _equipAmunitonController.Chest.CellController;
                    break;
                case TypeAmunition.Bracers:
                    cellInfoController.CellController = _equipAmunitonController.Bracers.CellController;
                    break;

            }
        }
    }
}
