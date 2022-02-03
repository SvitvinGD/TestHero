using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatisticsController : MonoBehaviour
{
    [SerializeField] private HeroController _heroController;

    [SerializeField] private TextMeshProUGUI name, lvl, attack, hitPoint, armor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        name.text = _heroController.Name;
        lvl.text = "Level: "+_heroController.Level;
        attack.text = _heroController.Attack + "";
        hitPoint.text = _heroController.HitPoint + "";
        armor.text = _heroController.Armor + "";
    }
}
