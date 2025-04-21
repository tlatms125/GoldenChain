using UnityEngine;

public class WarpInteraction : Interaction
{
   public WarpInteraction endWarp;
    public bool notReady;
    public override void StratInteraction(IInteractable interactable)
    {
        
    }
    public void Arrived()
    {
            notReady =true;
    }
    void OriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            notReady = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(notReady)
            return;

        if(collision.CompareTag("Player"))
        {
    
            endWarp.Arrived();
            Player.Instance.transform.position = endWarp.transform.position;
            endWarp.GetComponentInParent<Area>().StartArea();
            
        }
       
    }
    //시작지점 
    //도착지점
    //유저가 들어오면 도착지로

}
