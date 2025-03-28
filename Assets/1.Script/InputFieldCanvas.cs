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
        //����� �Է��� �κ��� ũ�� �� 
        //�Է·��� �ƽ����� ������ ��
        //�׿ܴ� �ٽ� �Է��϶����
        Debug.Log(InputField.text);
    }
    
}
