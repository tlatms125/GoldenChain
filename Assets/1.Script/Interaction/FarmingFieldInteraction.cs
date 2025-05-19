using UnityEngine;
using UnityEngine.Rendering;

public class FarmingFieldInteraction : MonoBehaviour, IInteractable
{
    public GameObject InteractionObject => gameObject;
    public PlantInteraction plant;
    public bool IsInteracting => false;
    
    public float wetTimer;
    public bool wet;
    public void Interact(IInteractable interactable)
    {
        //���� ���õ� ������ ���� �����ͼ� 
        //���� �ɱ�
      // plant = interactable.;  
      //�� ���� �Ĺ��� �ְ� �Ĺ�, ���� Ȥ�� ���� ��ȣ�ۿ��� �Ұ�����


      if(plant != null)
      {
        //�� ������ ��ȣ�ۿ� �ߴ��� ���ߴ��� �Ǻ� ?
        bool result = plant.Interact();

        if( !result)
        {
          //���ֱ�
          wet = true;
          wetTimer = 30;
        }
        
      }
      else
      {
        wet = false;
        wetTimer =0;
        PlantInfo info = PlantMgr.Instance.GetPlantInfo("Carrot");    
      plant = Instantiate(info.plantInteractionPrefab);
      plant.transform.position = transform.position;
      plant.StartPlant(this);
      }
     
      


    }
    public void Update()
    {
      if(plant == null)
      return;
      if(!wet)
      return;

      if(wetTimer <= 0)
      {
        wet = false;
        return;
      }
      wetTimer -= Time.deltaTime;
      
    }
    
    public void EndInteract()
    {
        
    }

   public void RemovePlant()
   {
      plant = null;
      wet = false;

   }
    public enum FieldState
    {
        Empty,
        Planted
    }
   
}
