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
            Debug.LogError("? inputField가 null입니다. 인스펙터에서 연결되었는지 확인하세요.");
            return;
        }

        if (inputFieldDialogue == null)
        {
            Debug.LogError("? inputFieldDialogue가 null입니다. 인스펙터에서 연결되었는지 확인하세요.");
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
        //사용자 입력이 민보다 크면 고 
        //입력량이 맥스보다 작으면 고
        //그외는 다시 입력하라고함
        Debug.Log(inputField.text);
    }
    
}
