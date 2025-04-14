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
// public class ItemData //스크랩터블 오브젝트로 아이템 구현