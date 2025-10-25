using UnityEngine;

public class CycleObject : MonoBehaviour
{
    public void Initialize()
    {
        this.gameObject.SetActive(true);
        
        //perform initialize of the prefabs scripts.
    }

    public void Reset()
    {
        // perform cleanup of the prefabs scripts.
        
        this.gameObject.SetActive(false);
    }
}
