using UnityEngine;
[CreateAssetMenu(fileName = "NormalDialogue", menuName = "Dialogue System/NormalDialogue")]
public class NormalDialogue : Dialogue
{
    public DialoqueLine[] dialoqueLines; // 대화내용 배열
    public Dialogue nextDialogue;
    public DialoqueLine GetNextLine(string conditionKey)
    {
        foreach(var line in dialoqueLines)
        {
            if(line.conditionKey == conditionKey)
            {
                return line; //조건에 맞는 대화라인 반환
            }
        }
        return null;
    }
    public NormalDialogue()
    {
        dialogueType = DialogueType.Normal;

    }
    

}
