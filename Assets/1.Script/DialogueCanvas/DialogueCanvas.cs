using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.TextCore.Text;
public class DialogueCanvas : MonoBehaviour
{
    public DialogueType dialogueType;
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public bool isTyping;
    public int idx;
    public IInteractable interactable;
    public virtual void StartDialogue(Dialogue dialoque, IInteractable interactable)
    {
        this.interactable = interactable;
        gameObject.SetActive(true);
        isTyping = false;
    }
    public virtual void UpdateDialogue()
    {
       // CharacterData characterData =  CharacterManager.Instance.GetCharacterData(dialoque.dialogueLines[idx].characterName);
        //  nameText.text = characterData.Name;
        //  isTyping = true;
        //  dialogueText.text =dialoque.dialoqueLines[idx].dialoqueText.ToString() ;
        // StartCoroutine(CoDialogue(dialoque.dialogueLines[idx].dialoqueText));
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

    // Update is called once per frame
    public virtual void Update()
    {

        if(Input.GetKeyDown(KeyCode.F))
        {
            if(isTyping == false) 
            {
                idx++;
                UpdateDialogue();
            
            }
            else
            {
                StopAllCoroutines();
               // dialogueText.text = dialoque.dialogueLines[idx].dialoqueText.ToString();
                isTyping = false;
            }
        }
    }
    public virtual bool IsFinishedLastIndex<T>(T[] array, int index)
    {
        return index >= array.Length;
    }
    
    
}



