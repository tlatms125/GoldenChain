using UnityEngine;
using TMPro;
public class InputFieldCanvas : DialogueCanvas
{
    public TMP_InputField inputField;
    public TMP_Text titleText;
    [SerializeField] InputFieldDialogue inputFieldDialogue;
   
    public void StartInputField (InputFieldDialogue dialogue)
    {
        inputFieldDialogue = dialogue;
        titleText.text = dialogue.title;
    }
    public void OnClickedCompleteButton()
    {
            if (inputField == null)
        {
            Debug.LogError("? inputField�� null�Դϴ�. �ν����Ϳ��� ����Ǿ����� Ȯ���ϼ���.");
            return;
        }

        if (inputFieldDialogue == null)
        {
            Debug.LogError("? inputFieldDialogue�� null�Դϴ�. �ν����Ϳ��� ����Ǿ����� Ȯ���ϼ���.");
            return;
        }
        
        if(inputFieldDialogue.minCharLimit > 0)
        {
            if(inputField.text.Length < inputFieldDialogue.minCharLimit)
            {
                
                return;
            }
        }
        if(inputFieldDialogue.maxCharLimit > 0) 
        {
            if(inputField.text.Length > inputFieldDialogue.maxCharLimit)
            {
                return;
            }
        }
        inputFieldDialogue.CompleteInput(inputField.text);
        //����� �Է��� �κ��� ũ�� �� 
        //�Է·��� �ƽ����� ������ ��
        //�׿ܴ� �ٽ� �Է��϶����
        Debug.Log(inputField.text);
    }
    
}
