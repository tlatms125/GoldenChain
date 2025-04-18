using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NPC : MonoBehaviour, IInteractable
{
    //NPC를 설정하고 플레이어가 NPC 근처에 가서 F키를 누르면 상호작용하기라는 로그를 출력해주세요.
    [SerializeField] bool IsPlayerInRange;
    [SerializeField] GameObject interactionUI;
    [SerializeField] CharacterName  characterName;
    public Interaction[] interactions;
    public bool isInteracting;
    public bool IsInteracting => isInteracting;

    public GameObject InteractionObject => gameObject;

    void Start()
    {
       // Player.Instance
       interactionUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if(IsPlayerInRange && Input.GetKeyDown(KeyCode.F))
        {
            if(IsInteracting)
                return;

            isInteracting = true;

            //상호작용
            Interact(this);
            interactionUI.gameObject.SetActive(false);
            
        }
    }
    public void EndInteract()
    {
        isInteracting = false;
    }
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsPlayerInRange = true;
            interactionUI.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsPlayerInRange = false;
            interactionUI.gameObject.SetActive(false);
        }
    }

    public void Interact(IInteractable interactable)
    {
        for(int i = 0; i < interactions.Length; i++)
        {
            interactions[i].StratInteraction(interactable);
        }
        //상호작용 끝나면 특정 함수 호출
        //조건에 만족하는지 검사
        //NPC와 상호작용 상세내용
        //대화 문구
        // Debug.Log("NPC와 상호작용!");
        // for(int i = 0; i<dialogueConditions.Length; i++)
        // {
        //     bool result =dialogueConditions[i].CheckCondition();
        //     if(result)
        //     {
        //       //  DialogueCanvas.Instance.StartDialogue(dialogueConditions[i].dialogue);
        //     }
            

      //  } 
       // DialogueCanvas.Instance.StartDialogue(dialoque);
    }

   
}
