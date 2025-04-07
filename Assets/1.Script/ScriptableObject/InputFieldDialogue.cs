using UnityEngine;
[CreateAssetMenu(fileName = "InputFieldDialogue", menuName = "Dialogue System/InputFieldDialogue")]
public class InputFieldDialogue : Dialogue
{
    public InputFieldType inputFieldType;
    public string title; 
    public Dialogue nextDialogue;
    public int maxCharLimit;
    public int minCharLimit;
    public void CompleteInput(string text)
    {
        if (inputFieldType == InputFieldType.UserName)
        {
            PlayerPrefs.SetString("UserName", text);
            //유저 데이터 스크립트 만들기
            // 타입이 유저 네임 이면 유저이름 저장
        }
        for(int i =0 ; i <  DialogueManager.Instance.dialogueCanvases.Length; i++)
        {
            if(nextDialogue.dialogueType == DialogueManager.Instance.dialogueCanvases[i].dialogueType)
            {
                DialogueManager.Instance.GetDialogueCanvas(DialogueManager.Instance.dialogueCanvases[i].dialogueType).StartDialogue(nextDialogue);
            }
        }    
 
    }
}
public enum InputFieldType
{
    UserName
    //..
}
