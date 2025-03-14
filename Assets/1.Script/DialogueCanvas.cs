using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.TextCore.Text;
public class DialogueCanvas : MonoBehaviour
{
    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public Dialoque dialoque;
    bool isTyping;
    private static DialogueCanvas instance;
    public static DialogueCanvas Instance
    {
        get
        {
            if (instance == null)
                instance = FindFirstObjectByType<DialogueCanvas>(FindObjectsInactive.Include);
            return instance;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int idx;
    public void StartDialogue(Dialoque dialoque)
    {
        this.dialoque = dialoque;
        idx = 0;
        //함수 호출시 대화시작
        gameObject.SetActive(true);
        isTyping = false;
        UpdateDialogue();
        
    }
    public void UpdateDialogue()
    {
        CharacterData characterData =  CharacterManager.Instance.GetCharacterData(dialoque.dialoqueLines[idx].characterName);
        nameText.text = characterData.Name;
        isTyping = true;
        //dialogueText.text =dialoque.dialoqueLines[idx].dialoqueText.ToString() ;
        StartCoroutine(CoDialogue(dialoque.dialoqueLines[idx].dialoqueText));
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
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            if(isTyping == false) 
            {
                idx++;
            UpdateDialogue();
            //타자 같이 써지는것
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text =dialoque.dialoqueLines[idx].dialoqueText.ToString();
                isTyping = false;
            }
        }
    }
    
}



