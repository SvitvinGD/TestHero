using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Window;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TabModel : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TypeTab _typeTab;
    [SerializeField] private bool _isActivity;
    [SerializeField] private Image _image;

    public Button Button
    {
        get => _button;
        set => _button = value;
    }

    public TypeTab TypeTab
    {
        get => _typeTab;
        set => _typeTab = value;
    }

    public bool IsActivity
    {
        get => _isActivity;
        set => _isActivity = value;
    }
    void Start()
    {
        switchColor();
    }

    public void switchColor()
    {
        if (_isActivity)
        {
            _image.color = new Color(0.4509f, 0.4509f, 0.4509f, 0);
        }
        else
        {
            _image.color = new Color(0.4509f, 0.4509f, 0.4509f, 1);
        }
    }
}
