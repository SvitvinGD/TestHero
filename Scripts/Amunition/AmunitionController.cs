using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmunitionController : MonoBehaviour
{
    [SerializeField] private List<AmunitionModel> _amunitionModels;

    public List<AmunitionModel> AmunitionModels
    {
        get => _amunitionModels;
        set => _amunitionModels = value;
    }
}
