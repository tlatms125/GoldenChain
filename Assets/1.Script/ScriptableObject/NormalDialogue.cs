using UnityEngine;
[CreateAssetMenu(fileName = "NormalDialogue", menuName = "Dialogue System/NormalDialogue")]
public class NormalDialogue : Dialogue
{
    public DialoqueLine[] dialoqueLines; // ��ȭ���� �迭
    public Dialogue nextDialogue;
    public DialoqueLine GetNextLine(string conditionKey)
    {
        foreach(var line in dialoqueLines)
        {
            if(line.conditionKey == conditionKey)
            {
                return line; //���ǿ� �´� ��ȭ���� ��ȯ
            }
        }
        return null;
    }
    public NormalDialogue()
    {
        dialogueType = DialogueType.Normal;

    }
    

}
