using UnityEngine;
using TMPro;
using System.Collections;
public class OptionalDialogueCanvas : DialogueCanvas
{
    [SerializeField] OptionalDialogue optionalDialogue;
    [SerializeField] OptionButton[] optionButtons;

    public override void StartDialogue(Dialogue dialoque)
    {
        optionalDialogue = dialoque as OptionalDialogue;
        for(int i = 0 ; i < optionButtons.Length; i++)
        {
            if(i < optionalDialogue.choiceOptions.Length)
            {
                optionButtons[i].gameObject.SetActive(true);
            }
            else
            {
                optionButtons[i].gameObject.SetActive(false);
            }
            // 갯수에 맞게 버튼 생성.
        }
        nameText.text = CharacterManager.Instance.GetName(optionalDialogue.characterName);
        dialogueText.text = Dialogue.GetDialogue(optionalDialogue.dialogueText);

    }   
    public void SelectedOption(int idx)
    {
        Dialogue nextDialogue = optionalDialogue.choiceOptions[idx].nextDialogue ;
        for(int i =0 ; i <  DialogueManager.Instance.dialogueCanvases.Length; i++)
        {
            if(nextDialogue.dialogueType == DialogueManager.Instance.dialogueCanvases[i].dialogueType)
            {
                DialogueManager.Instance.GetDialogueCanvas(DialogueManager.Instance.dialogueCanvases[i].dialogueType).StartDialogue(nextDialogue);
                
            }
            else
            {
                return;
            }
        } 
        
    }
    
}
