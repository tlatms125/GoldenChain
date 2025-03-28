using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
public class NormalDialogueCanvas : DialogueCanvas
{
    public NormalDialogue normalDialogue;
    // public TMP_Text nameText;
    // public TMP_Text dialogueText;
    bool isTyping;
       public override void StartDialogue(Dialogue dialoque)
    {
        normalDialogue = dialoque as NormalDialogue;
        idx = 0;
        
        // gameObject.SetActive(true);
        // isTyping = false;
        // UpdateDialogue();
        
    }

    // Update is called once per frame
    public override void UpdateDialogue()
    {
        //CharacterData characterData =  CharacterManager.Instance.GetCharacterData(normalDialogue.dialogueLines[idx].characterName);
        //  nameText.text = characterData.Name;
        //  isTyping = true;
        //  dialogueText.text =dialoque.dialoqueLines[idx].dialoqueText.ToString() ;
        // StartCoroutine(CoDialogue(dialoque.dialogueLines[idx].dialoqueText));
    }
}
