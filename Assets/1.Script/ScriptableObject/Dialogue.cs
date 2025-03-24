using UnityEngine;

//[CreateAssetMenu(fileName = "NewDialogue", menuName = "Dialogue System/Dialogue")]
public abstract class Dialogue : ScriptableObject
{
    public DialogueType dialogueType;
   
}
public enum DialogueType
{
    Normal,
    Choice
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
        if(conditionType == ConditionType.ItemOwned)
        {
            //���������� ������Ű �����ִ��� �Ǵ�
        }
        else if(conditionType == ConditionType.DialogueCount)
        {
             if(compareType == CompareType.Equals)
           {
            //ù��ȭ
            //if(User.Instance.UserData.DialogueCount == 0) � ���Ǿ����� ��ȭ���� ���� ��� �ұ�?
           }
        }
         else if(conditionType == ConditionType.ItemNotOwned)
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
    ItemOwned,        //  �������� �����ϰ� �ִ� ��� 
    ItemNotOwned,     //  �������� �������� ���� ��� 
    DialogueCount,    // ��ȭ Ƚ���� ���� �б� 
    Attractive,       // �ŷµ� (������ �ŷ� ��)
    Affection,        // ģ�е� (������ ģ����)
    PlayerChoice,     //  �÷��̾��� ���ÿ� ���� �б�
    QuestCompleted,   //  Ư�� ����Ʈ �Ϸ� ����
    TimeOfDay,        //  ��/�� ����
    Location,         //  Ư�� ��ҿ� ���� ��
    ReputationHigh,   //  �÷��̾� ���� ���� ��
    ReputationLow ,    //  �÷��̾� ���� ���� ��
    AnyEndingSeen      //������ �ѹ��̶� �ϳ��̻� ������
}
public enum CompareType
{
    Grater,
    Less,
    Equals,
    NotEquals
}