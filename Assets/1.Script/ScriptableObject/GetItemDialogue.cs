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

    }


}
