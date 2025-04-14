using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Constraints;
public class NormalDialogueCanvas : DialogueCanvas
{
    public NormalDialogue normalDialogue;
    // public TMP_Text nameText;
    // public TMP_Text dialogueText;
    
    
    public override void Update()
    {

        if(Input.GetKeyDown(KeyCode.F))
        {
            if(isTyping == false) 
            {
                
                idx++;
                if (IsFinishedLastIndex(normalDialogue.dialogueLines, idx))
                {
                    normalDialogue.CompleteDialogue(interactable);
                   
                    gameObject.SetActive(false);
                    return;
                }
                UpdateDialogue();
            
            }
            else
            {
               
                StopAllCoroutines();
                dialogueText.text =normalDialogue.dialogueLines[idx].GetDialogue();
                isTyping = false;
              
                
            }
        }
    }
    
    
    public override void StartDialogue(Dialogue dialoque,IInteractable interactable)
    { 
        base.StartDialogue(dialoque, interactable);

        normalDialogue = dialoque as NormalDialogue;
        idx = 0;
       
    
        UpdateDialogue();
        
    }

    // Update is called once per frame
    public override void UpdateDialogue()
    {
        CharacterData characterData =  CharacterManager.Instance.GetCharacterData(normalDialogue.dialogueLines[idx].characterName);
      
        nameText.text = characterData.Name;
        Debug.Log(nameText.text);
        isTyping = true;
        //dialogueText.text =normalDialogue.dialogueLines[idx].dialogueText.;
        
        StartCoroutine(CoDialogue(normalDialogue.dialogueLines[idx].GetDialogue()));
        
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
