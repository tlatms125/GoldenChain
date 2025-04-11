using UnityEngine;
[CreateAssetMenu(fileName = "NormalDialogue", menuName = "Dialogue System/NormalDialogue")]
public class NormalDialogue : Dialogue
{
    public NormalDialogue()
    {
        dialogueType = DialogueType.Normal;

    }
    public DialogueLine[] dialogueLines; // 대화내용 배열
    public Dialogue nextDialogue; //현재 대화가 끝나면 시작될 대화, 없으면 대화 종료

    public DialogueLine GetNextLine(ConditionType conditionType)
    {
        foreach(var line in dialogueLines)
        {
            if(line.conditionType == conditionType)
            {
                return line; //조건에 맞는 대화라인 반환
            }
        }
       
        return null;
    }
    public override void CompleteDialogue(IInteractable interactable)
    {
        if(nextDialogue != null)
        {
            for(int i =0 ; i <  DialogueManager.Instance.dialogueCanvases.Length; i++)
            {
                if(nextDialogue.dialogueType == DialogueManager.Instance.dialogueCanvases[i].dialogueType)
                {
                    DialogueManager.Instance.GetDialogueCanvas(DialogueManager.Instance.dialogueCanvases[i].dialogueType).StartDialogue(nextDialogue, interactable);
                }
            }   
        }
        else
        {
            Debug.Log("nextDialogue가 없습니다.");
            interactable.EndInteract();

        }
         
    }

}
[System.Serializable]
public class DialogueLine
{
    public CharacterName characterName;
    public string dialogueText;
    public ConditionType conditionType; //대화가 나올 조건을 체크할 키
    public bool conditionMet; // 조건을 만족했는지 체크하는 플래그

    public string GetDialogue()
    {
        
        return Dialogue.GetDialogue(dialogueText);
    }

}
