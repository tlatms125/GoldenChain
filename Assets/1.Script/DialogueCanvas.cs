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
        //�Լ� ȣ��� ��ȭ����
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
    public string conditionKey; //��ȭ�� ���� ������ üũ�� Ű
    public bool conditionMet; // ������ �����ߴ��� üũ�ϴ� �÷���

}

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
