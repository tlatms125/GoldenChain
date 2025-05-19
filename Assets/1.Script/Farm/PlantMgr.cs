using UnityEngine;
using System.Linq;

public class PlantMgr : MonoSingleton<PlantMgr>
{
    [SerializeField] PlantInfo[] plantInfos;
    public override void Awake()
    {
        Debug.Log("PlantMgr_Awake()");
        plantInfos = Resources.LoadAll<PlantInfo>("Plant");
    }
    
    public PlantInfo GetPlantInfo(string key)
    {
        return plantInfos.Where(e => e.key == key).FirstOrDefault();
    }
}
