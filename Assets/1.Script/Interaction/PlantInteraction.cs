using UnityEngine;

public class PlantInteraction : MonoBehaviour, IInteractable
{
    public string key;
    public PlantState curState; //현재 상태
    public GameObject InteractionObject => gameObject;

    public float exp;
    

    public bool IsInteracting => false;

//식물 성장 관련 기능  흙 젖은흙 성장 과일 수확

    public void StartPlant(FarmingFieldInteraction farmingField)
    {
        curState = PlantState.Seed;
        
    }
    public void Interact(IInteractable interactable)
    {
        //성장함.
    }
    
    public void EndInteract()
    {
        
    }

    

   
}
public enum PlantState
{
    Seed,
    GrowUp,
    Complete
}
