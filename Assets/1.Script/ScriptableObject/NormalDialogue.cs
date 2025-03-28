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

    public DialogueLine GetNextLine(string conditionKey)
    {
        foreach(var line in dialogueLines)
        {
            if(line.conditionKey == conditionKey)
            {
                return line; //조건에 맞는 대화라인 반환
            }
        }
        return null;
    }
    

}
[System.Serializable]
public class DialogueLine
{
    public CharacterName characterName;
    public string dialogueText;
    public string conditionKey; //대화가 나올 조건을 체크할 키
    public bool conditionMet; // 조건을 만족했는지 체크하는 플래그

}
