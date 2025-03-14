using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    //NPC를 설정하고 플레이어가 NPC 근처에 가서 F키를 누르면 상호작용하기라는 로그를 출력해주세요.
    [SerializeField] bool IsPlayerInRange;
    [SerializeField] GameObject interactionUI;
    [SerializeField] CharacterName  characterName;
    public Dialoque dialoque;

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
          
                //상호작용
                Interact();
                interactionUI.gameObject.SetActive(false);
            
        }
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

    public void Interact()
    {
        //NPC와 상호작용 상세내용
        //대화 문구
        Debug.Log("NPC와 상호작용!");
        DialogueCanvas.Instance.StartDialogue(dialoque);
    }
}
