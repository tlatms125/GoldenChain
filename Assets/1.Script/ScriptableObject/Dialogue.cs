using UnityEngine;

[CreateAssetMenu(fileName = "NewDialogue", menuName = "Dialogue System/Dialogue")]
public class Dialogue : ScriptableObject
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
[System.Serializable]
public class DialogueCondition
{
    public Dialogue dialogue;
    public Condition[] conditions;
    public bool CheckCondition()
    {
        //Conditions�� ��� ������ ���ΰ�� Ture
        //�ϳ��� �Ҹ����̸� false
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
            //���������� ������Ű �����ִ��� �Ǵ�
        }
        else if(conditionType == ConditionType.FirstDialogue)
        {
            //���������� ���Ǿ����� ��ȭ ����ߴ��� �Ǵ�
        }
         else if(conditionType == ConditionType.nothasItem)
        {
            //���������� ������Ű �����ִ��� �Ǵ�
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
    
    //�ŷµ�
    //ģ�е�? ��? ���̻�
}
public enum CompareType
{
    Grater,
    Less,
    Equals,
    NotEquals
}