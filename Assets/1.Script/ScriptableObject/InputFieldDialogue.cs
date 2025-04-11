using UnityEngine;
[CreateAssetMenu(fileName = "InputFieldDialogue", menuName = "Dialogue System/InputFieldDialogue")]
public class InputFieldDialogue : Dialogue
{
    public InputFieldType inputFieldType;
    
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
                //스타트 다이알로그 말고 텍스트를 넘겨줘야함 
            }
            else
            {
                return;
            }
        } 
        
 
    }
    public override void CompleteDialogue()
    {
        
    }

}
public enum InputFieldType
{
    UserName
    //..
}
