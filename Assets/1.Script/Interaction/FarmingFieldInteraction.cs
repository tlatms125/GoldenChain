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
        //현재 선택된 씨앗이 뭔지 가져와서 
        //씨앗 심기
      // plant = interactable.;  
      //그 땅에 식물이 있고 식물, 수집 혹은 제거 상호작용을 할것인지


      if(plant != null)
      {
        //이 시점에 상호작용 했는지 안했는지 판별 ?
        bool result = plant.Interact();

        if( !result)
        {
          //물주기
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
