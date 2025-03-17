using UnityEngine;

[CreateAssetMenu(fileName = "NewDialogue", menuName = "Dialogue System/Dialogue")]
public class Dialogue : ScriptableObject
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
[System.Serializable]
public class DialogueCondition
{
    public Dialogue dialogue;
    public Condition[] conditions;
    public bool CheckCondition()
    {
        //Conditions의 모든 조건이 참인경우 Ture
        //하나라도 불만족이면 false
        for(int i = 0; i < conditions.Length ; i++)
        {
            if(!conditions[i].CheckCondition())
            {
                return false;
            }
        } 

        return true;
    }
    
}
[System.Serializable]
public class Condition
{
    public ConditionType conditionType;
    public string conditionValue;
    public CompareType compareType;
    public bool CheckCondition()
    {
        if(conditionType == ConditionType.HasItem)
        {
            //유저데이터 아이템키 갖고있는지 판단
        }
        else if(conditionType == ConditionType.FirstDialogue)
        {
            //유저데이터 엔피씨마다 대화 몇번했는지 판단
        }
         else if(conditionType == ConditionType.nothasItem)
        {
            //유저데이터 아이템키 갖고있는지 판단
        }
         else if(conditionType == ConditionType.Attractive)
        {
            int standardAtt = int.Parse(conditionValue);
           if(compareType == CompareType.Grater)
           {
                //if(User.Instance.UserData.attractive >= standardAtt)
                // {
                //     return true;
                // }
                // else
                // {
                //     return false;
                // }
             
           } 
        }
        return true;
    }
}
public enum ConditionType
{
    HasItem,
    FirstDialogue,
    nothasItem,
    Attractive,
    
    //매력도
    //친밀도? 명성? 몇이상
}
public enum CompareType
{
    Grater,
    Less,
    Equals,
    NotEquals
}