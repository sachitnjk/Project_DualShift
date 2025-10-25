using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [Header("UI Element Prefabs")]
    [SerializeField] private GameObject cycleUIManager_ObjectPrefab;
    
    private CycleUIManager cycleUIManager;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        if (cycleUIManager == null && cycleUIManager_ObjectPrefab != null)
        {
            GameObject spawnedObject = Instantiate(cycleUIManager_ObjectPrefab, transform);
            cycleUIManager = spawnedObject?.GetComponent<CycleUIManager>();
        }
    }
}
