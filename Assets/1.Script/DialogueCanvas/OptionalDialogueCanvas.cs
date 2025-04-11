using UnityEngine;
using TMPro;
using System.Collections;
public class OptionalDialogueCanvas : DialogueCanvas
{
    [SerializeField] OptionalDialogue optionalDialogue;
    [SerializeField] OptionButton[] optionButtons;


    public override void StartDialogue(Dialogue dialoque,IInteractable interactable)
    {
        base.StartDialogue(dialoque, interactable);
        optionalDialogue = dialoque as OptionalDialogue;
        for(int i = 0 ; i < optionButtons.Length; i++)
        {
            if(i < optionalDialogue.choiceOptions.Length)
            {
                optionButtons[i].gameObject.SetActive(true);
                optionButtons[i].buttonText.text = optionalDialogue.choiceOptions[i].GetDialogue(optionalDialogue.characterName);
            }
            else
            {
                optionButtons[i].gameObject.SetActive(false);
            }
            // 갯수에 맞게 버튼 생성.
        }
        nameText.text = CharacterManager.Instance.GetName(optionalDialogue.characterName);
        dialogueText.text = Dialogue.GetDialogue(optionalDialogue.characterName,optionalDialogue.dialogueText);
        

    }   
    public void SelectedOption(int idx)
    {
        Dialogue nextDialogue = optionalDialogue.choiceOptions[idx].nextDialogue ;
        if(nextDialogue != null)
        {
            DialogueCanvas dialogueCanvas = DialogueManager.Instance.GetDialogueCanvas(nextDialogue.dialogueType);
            dialogueCanvas.StartDialogue(nextDialogue, interactable);
        }
        else
        {
            interactable.EndInteract();
        }
        gameObject.SetActive(false);
        
    }
    
}
