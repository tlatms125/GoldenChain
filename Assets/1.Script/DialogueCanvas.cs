using UnityEngine;

public class DialogueCanvas : MonoBehaviour
{
    private static DialogueCanvas instance;
    public static DialogueCanvas Instance
    {
        get
        {
            if (instance == null)
                instance = FindFirstObjectByType<DialogueCanvas>(FindObjectsInactive.Include);
            return instance;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartDialouge()
    {
        //함수 호출시 대화시작
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class DialoqueLine
{
    public string characterName;
    public string dialoqueText;
    public string conditionKey; //대화가 나올 조건을 체크할 키
    public bool conditionMet; // 조건을 만족했는지 체크하는 플래그

}

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
