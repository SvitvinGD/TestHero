using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class InfoController : MonoBehaviour
{
    [SerializeField] private CellInfoController _cellInfoController;
    
    public void GetItem(CellController cellController)
    {
        if (cellController.AmunitionModel != null)
        {
            _cellInfoController.gameObject.active = true;
            _cellInfoController.CellController = cellController;
        }

    }

    public void Close()
    {
        _cellInfoController.gameObject.active = false;
    }
}
