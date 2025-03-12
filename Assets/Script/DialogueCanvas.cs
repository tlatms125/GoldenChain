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
public class Dialoque
{
    public string name;
    public string script;
}
