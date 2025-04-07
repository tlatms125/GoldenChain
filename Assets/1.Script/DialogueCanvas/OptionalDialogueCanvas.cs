using UnityEngine;
using TMPro;
using System.Collections;
public class OptionalDialogueCanvas : DialogueCanvas
{
    OptionalDialogue optionalDialogue;
    [SerializeField] OptionButton[] optionButtons;

    public override void StartDialogue(Dialogue dialoque)
    {
        optionalDialogue = dialoque as OptionalDialogue;
        for(int i = 0 ; i < optionButtons.Length; i++)
        {
            // ������ �°� ��ư ����.
        }
        nameText.text = CharacterManager.Instance.GetName(optionalDialogue.characterName);
        dialogueText.text = Dialogue.GetDialogue(optionalDialogue.dialogueText);

    }   
    
}
