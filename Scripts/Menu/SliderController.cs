using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] private RectTransform menu;
    [SerializeField] private Vector3 max;
    [SerializeField] private Vector3 min;
    [SerializeField] private Slider _slider;

    void Start()
    {
        menu.anchoredPosition3D =  min;
    }

    void Update()
    {
        menu.anchoredPosition3D = new Vector3(max.x, min.y +((max.y - min.y) * _slider.value), max.z);
    }
}
