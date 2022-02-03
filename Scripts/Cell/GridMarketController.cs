using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMarketController : MonoBehaviour
{
    [SerializeField] private List<CellMarketController> _cellControllers;
    // Update is called once per frame
    void Update()
    {
        for (int i = 0, j = 0, k = 0; i < _cellControllers.Count; i++)
        {
            if (!_cellControllers[i].IsEmpty)
            {
                if (j == 3)
                {
                    j = 0;
                    k++;
                }
                _cellControllers[i].RectTransform.anchoredPosition3D = new Vector3(420 * j, 250 - 150 * k, 0);
                j++;
            }
            else
            {
                RemuveComponent(_cellControllers[i]);
            }
        }
    }

    public void RemuveComponent(CellMarketController cellMarketController)
    {
        CellMarketController temp = cellMarketController;
        _cellControllers.Remove(cellMarketController);
        Destroy(temp.gameObject);
    }
}
