using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    [SerializeField] private List<CellController> _cellControllers;
    [SerializeField] private int _countCell;
    [SerializeField] private int _emptyCell;

    public int CountCell
    {
        get => _countCell;
        set => _countCell = value;
    }

    public int EmptyCell
    {
        get => _emptyCell;
        set => _emptyCell = value;
    }

    public List<CellController> CellControllers
    {
        get => _cellControllers;
        set => _cellControllers = value;
    }

    void Update()
    {
        _countCell = _cellControllers.Count;
        for (int i = 0, count = 0; i < _cellControllers.Count; i++)
        {
            if (_cellControllers[i].IsEmpty)
                _emptyCell = count++;
        }
    }

    public bool AddItem(AmunitionModel amunitionModel)
    {
        for (int i = 0; i < _cellControllers.Count; i++)
        {
            if (_cellControllers[i].IsEmpty)
            {
                _cellControllers[i].IsEmpty = false;
                _cellControllers[i].AmunitionModel = amunitionModel;
                return true;
            }
        }

        return false;
    }
}
