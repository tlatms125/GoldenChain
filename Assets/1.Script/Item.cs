using UnityEngine;

public class Item : MonoBehaviour, IInteractable
{
    bool isInteracting;
    public GameObject InteractionObject => gameObject;

    public bool IsInteracting => isInteracting;

    public void EndInteract()
    {
        isInteracting = false;
    }


    public void Interact(IInteractable interactable)
    {
        
    }
}
