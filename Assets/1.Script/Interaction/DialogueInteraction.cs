using UnityEngine;

public class DialogueInteraction : Interaction
{
    
    [SerializeField] public DialogueCondition[] dialogueConditions;

    public override void StratInteraction()
    {

       for (int i = 0; i < dialogueConditions.Length; i++)
       {
            if(dialogueConditions[i].CheckCondition())
            {
              DialogueManager.Instance.GetDialogueCanvas (dialogueConditions[i].dialogue.dialogueType).StartDialogue(dialogueConditions[i].dialogue);
              return;

            }
       }
    }

}

