using UnityEngine;

[CreateAssetMenu(fileName = "NewDialogue", menuName = "Dialogue System/Dialogue")]
public class Dialoque : ScriptableObject
{
    public DialoqueLine[] dialoqueLines; // 대화내용 배열

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
}
[System.Serializable]
public class DialoqueLine
{
    public CharacterName characterName;
    public string dialoqueText;
    public string conditionKey; //대화가 나올 조건을 체크할 키
    public bool conditionMet; // 조건을 만족했는지 체크하는 플래그

}