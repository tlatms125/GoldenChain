using UnityEngine;

public class PlantInteraction : MonoBehaviour, IInteractable
{
    public string key;
    public PlantState[] plantStates; // ����ܰ�
    public PlantState curState; //���� ����
    public GameObject InteractionObject => gameObject;

    public bool IsInteracting => false;

//�Ĺ� ���� ���� ���  �� ������ ���� ���� ��Ȯ
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
