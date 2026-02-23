using UnityEngine;

public class ResetStaticDataManager : MonoBehaviour
{
    public void Awake()
    {
        CuttingCounter.ResetStaticData();
        BaseCounter.ResetStaticData();
        TrashCounter.ResetStaticData();
    }
}