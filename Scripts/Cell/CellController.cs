using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellController : MonoBehaviour
{
    [SerializeField] private AmunitionModel _amunitionModel;
    [SerializeField] private Image _imageAmunition;
    [SerializeField] private bool _isEmpty;
    [SerializeField] private bool isEqup;

    public AmunitionModel AmunitionModel
    {
        get => _amunitionModel;
        set => _amunitionModel = value;
    }

    public Image ImageAmunition
    {
        get => _imageAmunition;
        set => _imageAmunition = value;
    }

    public bool IsEmpty
    {
        get => _isEmpty;
        set => _isEmpty = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateCell();
    }

    private void UpdateCell()
    {
        if (_amunitionModel != null)
        {
            if (!isEqup)
            {
                _imageAmunition.sprite = _amunitionModel.Amunition.Sprite;
            }
            _isEmpty = false;
        }
        else
        {
            _isEmpty = true;
        }

        if (!isEqup)
        {
            if (_isEmpty)
            {
                _imageAmunition.sprite = null;
                _imageAmunition.color = new Color(0.4509f, 0.4509f, 0.4509f, 1);
            }
            else
            {
                _imageAmunition.color = new Color(1, 1, 1, 1);
            }
        }
    }
}
