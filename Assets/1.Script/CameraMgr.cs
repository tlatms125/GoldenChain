using UnityEngine;
using Unity.Cinemachine;
public class CameraMgr : MonoSingleton<CameraMgr>
{
   public CinemachineConfiner2D confiner2D;

    public override void Awake()
    {
        base.Awake();
        confiner2D = GetComponentInChildren<CinemachineConfiner2D>();
    }
    public void ChangeBounding(Collider2D collider2D)
    {
        confiner2D.BoundingShape2D = collider2D;
        
    }
}
