using UnityEngine;
using TMPro;
public class InputFieldCanvas : DialogueCanvas
{
    public TMP_InputField InputField;
    public TMP_Text titleText;
    public int maxCharLimit;
    public int minCharLimit;

    public void StartInputField (InputFieldDialogue dialogue)
    {
        titleText.text = dialogue.title;
    }
    public void OnClickedCompleteButton()
    {
        //사용자 입력이 민보다 크면 고 
        //입력량이 맥스보다 작으면 고
        //그외는 다시 입력하라고함
        Debug.Log(InputField.text);
    }
    
}
