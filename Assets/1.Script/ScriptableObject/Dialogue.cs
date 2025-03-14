using UnityEngine;

[CreateAssetMenu(fileName = "NewDialogue", menuName = "Dialogue System/Dialogue")]
public class Dialoque : ScriptableObject
{
    public DialoqueLine[] dialoqueLines; // ��ȭ���� �迭

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
}
[System.Serializable]
public class DialoqueLine
{
    public CharacterName characterName;
    public string dialoqueText;
    public string conditionKey; //��ȭ�� ���� ������ üũ�� Ű
    public bool conditionMet; // ������ �����ߴ��� üũ�ϴ� �÷���

}