using UnityEngine;
using TMPro;
public class DialogueManager : MonoSingleton<DialogueManager>
{
    public DialogueCanvas[] dialogueCanvases;
    public DialogueCanvas GetDialogueCanvas(DialogueType type)
    {
        for(int i = 0; i <= dialogueCanvases.Length; i++)
        {
            if(dialogueCanvases[i].dialogueType == type)
            {
                return dialogueCanvases[i];
            }
        } 
        return null;
    }

}
