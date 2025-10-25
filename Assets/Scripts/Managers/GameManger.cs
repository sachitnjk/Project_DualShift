using System;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static GameManger Instance { get; private set; }
    
    //Public references
    public DayNightManager dayNightManager;
    public ObjectLoader objectLoader;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        if (dayNightManager != null)
        {
            dayNightManager.Initialize();
        }
    }
}
