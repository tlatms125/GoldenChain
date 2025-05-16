using UnityEngine;

public class FarmingFieldInteraction : MonoBehaviour, IInteractable
{
    public GameObject InteractionObject => gameObject;
    public PlantInteraction plant;
    public bool IsInteracting => false;
    
    public float wetTimer;
    public bool watering;
    public void Interact(IInteractable interactable)
    {
        //ÇöÀç ¼±ÅÃµÈ ¾¾¾ÑÀÌ ¹ºÁö °¡Á®¿Í¼­ 
        //¾¾¾Ñ ½É±â
      // plant = interactable.;  
      if(plant != null)
      {
        //¹°ÁÖ±â
        watering = true;
        wetTimer = 30;
      }
      else
      {
        watering = false;
        wetTimer =0;
         PlantInfo info = PlantMgr.Instance.GetPlantInfo("Carrot");    
      plant = Instantiate(info.plantInteractionPrefab);
      plant.transform.position = transform.position;
      plant.StartPlant(this);
      }
     
      


    }
    
    public void EndInteract()
    {
        
    }

   
    public enum FieldState
    {
        Empty,
        Planted
    }
   
}
