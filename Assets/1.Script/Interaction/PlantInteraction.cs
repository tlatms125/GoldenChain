using UnityEngine;

public class PlantInteraction : MonoBehaviour, IInteractable
{
    public string key;
    public PlantState curState; //���� ����
    public GameObject InteractionObject => gameObject;

    public float exp;
    

    public bool IsInteracting => false;

//�Ĺ� ���� ���� ���  �� ������ ���� ���� ��Ȯ

    public void StartPlant(FarmingFieldInteraction farmingField)
    {
        curState = PlantState.Seed;
        
    }
    public void Interact(IInteractable interactable)
    {
        //������.
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
