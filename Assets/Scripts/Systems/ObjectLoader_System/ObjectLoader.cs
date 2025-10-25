using System;
using System.Collections.Generic;
using Enums;
using UnityEngine;

public class ObjectLoader : MonoBehaviour
{
    public List<CycleObject> dayCycleObjectsList;
    public List<CycleObject> nightCycleObjectsList;

    private DayNightManager dayNightManagerReference;
    
    private void Start()
    {
        dayNightManagerReference = GameManger.Instance.dayNightManager;
    }

    public void LoadCycleObjects(TimeCycle timeCycle)
    {
        bool isDay = timeCycle == TimeCycle.Day;

        //Fade in
        
        foreach (CycleObject cycleObject in dayCycleObjectsList)
        {
            if (cycleObject != null)
            {
                // if (isDay) cycleObject.Initialize();
                // else cycleObject.ResetObject();
            }
        }

        foreach (CycleObject cycleObject in nightCycleObjectsList)
        {
            if (cycleObject != null)
            {
                // if (!isDay) cycleObject.Initialize();
                // else cycleObject.ResetObject();
            }
        }
        
        //Fade out
    }

    public void RegisterCycleObject(CycleObject cycleObject)
    {
        if (dayNightManagerReference.GetTimeCycle() == TimeCycle.Day)
        {
            dayCycleObjectsList.Add(cycleObject);
        }
        else
        {
            nightCycleObjectsList.Add(cycleObject);
        }
    }

    public void UnregisterCycleObject(CycleObject cycleObject)
    {
        if (dayNightManagerReference.GetTimeCycle() == TimeCycle.Day)
        {
            if (dayCycleObjectsList.Contains(cycleObject))
            {
                dayCycleObjectsList.Remove(cycleObject);
            }
            else
            {
                if (nightCycleObjectsList.Contains(cycleObject))
                {
                    nightCycleObjectsList.Remove(cycleObject);
                }
            }
        }
    }
}
