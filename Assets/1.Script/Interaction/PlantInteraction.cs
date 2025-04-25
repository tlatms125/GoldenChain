using UnityEngine;

public class PlantInteraction : MonoBehaviour, IInteractable
{
    public string key;
    public PlantState[] plantStates; // 성장단계
    public PlantState curState; //현재 상태
    public GameObject InteractionObject => gameObject;

    public bool IsInteracting => false;

//식물 성장 관련 기능  흙 젖은흙 성장 과일 수확
    public void EndInteract()
    {
        
    }

    public void Interact(IInteractable interactable)
    {
        
    }

   
}
public enum PlantState
{
    Seed,
    GrowUp,
    Complete
}
