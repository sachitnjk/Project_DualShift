using Enums;
using UnityEngine;

public class DayNightManager : MonoBehaviour
{
    private int _currentCycleIndex = 0;

    public void Initialize()
    {
        _currentCycleIndex = 0;
        //Load Objects for currentCycleIndex
    }
    
    public void TriggerCycleChange()
    {
        _currentCycleIndex = 1 - _currentCycleIndex;
        
        GameManger.Instance.objectLoader.LoadCycleObjects(GetTimeCycle());
    }

    public TimeCycle GetTimeCycle()
    {
        if (_currentCycleIndex == 0) return TimeCycle.Day;

        return TimeCycle.Night;
    }
}
