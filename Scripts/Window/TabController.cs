using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Window;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{

    [SerializeField] private TabModel bug;
    [SerializeField] private TabModel statistics;
    [SerializeField] private TypeTab activityTab;
    [SerializeField] private GameObject bugWindow;
    [SerializeField] private GameObject statisticWindow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwichTab(TabModel tabModel)
    {
        switch (tabModel.TypeTab)
        {
            case TypeTab.Bug:
                if (tabModel.IsActivity)
                    break;
                tabModel.IsActivity = true;
                statistics.IsActivity = false;
                activityTab = TypeTab.Bug;
                bugWindow.active = true;
                statisticWindow.active = false;
                bug.switchColor();
                statistics.switchColor();
                break;
            case TypeTab.Statistics:
                if (tabModel.IsActivity)
                    break;
                tabModel.IsActivity = true;
                bug.IsActivity = false;
                activityTab = TypeTab.Statistics;
                statisticWindow.active = true;
                bugWindow.active = false;
                bug.switchColor();
                statistics.switchColor();
                break;
            
        }
    }
}
