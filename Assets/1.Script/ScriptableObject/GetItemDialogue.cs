using UnityEngine;

[CreateAssetMenu(fileName = "GetIteimDialogue", menuName = "Dialogue System/GetIteimDialogue")]
public class GetItemDialogue : Dialogue
{
    public GetItemDialogue()
    {
        dialogueType =DialogueType.GetItem;
    }
    public CharacterName characterName;
    public string itemKey;
    public string dialogueText;
    public Dialogue nextDialogue;
    public override void CompleteDialogue(IInteractable interactable)
    {
        // for(int i =0 ; i < ItemData.length; i++)
        // {
        //     ItemData[i].itemKey = itemKey;
        //     User.Instance.userData.getItem(itemKey);
        //     return ItemData[i];
        // }
        // itemKey에 해당하는 아이템 획득처리

        if(nextDialogue != null)
        {
            for(int i =0 ; i <  DialogueManager.Instance.dialogueCanvases.Length; i++)
            {
                if(nextDialogue.dialogueType == DialogueManager.Instance.dialogueCanvases[i].dialogueType)
                {
                    DialogueManager.Instance.GetDialogueCanvas(DialogueManager.Instance.dialogueCanvases[i].dialogueType).StartDialogue(nextDialogue, interactable);
                }
            }
        }
        else
        {
            // 없으면 상호작용을 끝내는 처리
            interactable.EndInteract();
        }
        // nextDialogue 존재하는지 확인해서 진행하는 처리
        
    }
    


}
