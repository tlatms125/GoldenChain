using UnityEngine;

//[CreateAssetMenu(fileName = "NewDialogue", menuName = "Dialogue System/Dialogue")]
public abstract class Dialogue : ScriptableObject
{
    public DialogueType dialogueType;
    public string title;
   
    public static string GetDialogue(string text)
    {
        string finalDialogue = text.Replace(("(nick)"),PlayerPrefs.GetString("UserName"));
        return finalDialogue;
    }
    public virtual void CompleteDialogue()
    {
        
    }
   
}
public enum DialogueType
{
    Normal,
    Optional,
    InputField,
    num
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
        if(conditionType == ConditionType.ItemOwned)
        {
            //유저데이터 아이템키 갖고있는지 판단
        }
        else if(conditionType == ConditionType.DialogueCount)
        {
             if(compareType == CompareType.Equals)
           {
            //첫대화
            //if(User.Instance.UserData.DialogueCount == 0) 어떤 엔피씨와의 대화인지 구분 어떻게 할까?
           }
        }
         else if(conditionType == ConditionType.ItemNotOwned)
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
    ItemOwned,        //  아이템을 소지하고 있는 경우 
    ItemNotOwned,     //  아이템을 소지하지 않은 경우 
    DialogueCount,    // 대화 횟수에 따른 분기 
    Attractive,       // 매력도 (외형적 매력 등)
    Affection,        // 친밀도 (관계의 친밀함)
    PlayerChoice,     //  플레이어의 선택에 따른 분기
    QuestCompleted,   //  특정 퀘스트 완료 여부
    TimeOfDay,        //  낮/밤 여부
    Location,         //  특정 장소에 있을 때
    ReputationHigh,   //  플레이어 명성이 높을 때
    ReputationLow ,    //  플레이어 명성이 낮을 때
    AnyEndingSeen      //엔딩을 한번이라도 하나이상 봤을때
}
public enum CompareType
{
    Grater,
    Less,
    Equals,
    NotEquals
}