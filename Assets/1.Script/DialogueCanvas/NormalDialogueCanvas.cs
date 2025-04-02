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

    public override void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            if(isTyping == false) 
            {
                idx++;
            UpdateDialogue();
            
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text =normalDialogue.dialogueLines[idx].dialogueText.ToString();
                isTyping = false;
            }
        }
    }
    public override void StartDialogue(Dialogue dialoque)
    { 
        normalDialogue = dialoque as NormalDialogue;
        idx = 0;
        gameObject.SetActive(true);
        isTyping = false;
       
        
       
         UpdateDialogue();
        
    }

    // Update is called once per frame
    public override void UpdateDialogue()
    {
        CharacterData characterData =  CharacterManager.Instance.GetCharacterData(normalDialogue.dialogueLines[idx].characterName);
        nameText.text = characterData.Name;
        isTyping = true;
        dialogueText.text =normalDialogue.dialogueLines[idx].dialogueText.ToString() ;
        StartCoroutine(CoDialogue(normalDialogue.dialogueLines[idx].dialogueText));
    }
     IEnumerator CoDialogue(string script )
    {
        dialogueText.text = "";
        char[] chars = script.ToCharArray();
        for(int i =0; i<chars.Length;i++)
        {
            yield return new WaitForSeconds(0.2f);
            dialogueText.text += chars[i];
        }
        isTyping =false;

    }

}
