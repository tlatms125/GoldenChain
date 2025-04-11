using System;
using UnityEngine;

public class DialogueInteraction : Interaction
{
    
    [SerializeField] public DialogueCondition[] dialogueConditions;

    public override void StratInteraction(IInteractable interactable)
    {

       for (int i = 0; i < dialogueConditions.Length; i++)
       {
            if(dialogueConditions[i].CheckCondition())
            {
              DialogueCanvas canvas = DialogueManager.Instance.GetDialogueCanvas(dialogueConditions[i].dialogue.dialogueType);
              canvas.StartDialogue(dialogueConditions[i].dialogue, interactable);
              return;

            }
       }
    }

}

