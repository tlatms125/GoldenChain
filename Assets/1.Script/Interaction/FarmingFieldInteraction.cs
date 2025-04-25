using UnityEngine;

public class FarmingFieldInteraction : MonoBehaviour, IInteractable
{
    public GameObject InteractionObject => gameObject;
    public PlantInteraction plant;
    public bool IsInteracting => false;

    
    public void EndInteract()
    {
        
    }

    public void Interact(IInteractable interactable)
    {
        
    }
    public enum FieldState
    {
        Empty,
        Planted
    }
   
}
