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
            //���� ������ ��ũ��Ʈ �����
            // Ÿ���� ���� ���� �̸� �����̸� ����
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
