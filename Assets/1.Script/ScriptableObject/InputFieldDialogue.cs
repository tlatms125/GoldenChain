using UnityEngine;
[CreateAssetMenu(fileName = "InputFieldDialogue", menuName = "Dialogue System/InputFieldDialogue")]
public class InputFieldDialogue : Dialogue
{
    public InputFieldType inputFieldType;

    public string title; 
    public Dialogue nextDialouge;
    public void CompleteInput()
    {
        // Ÿ���� ���� ���� �̸� �����̸� ����

        // �ؽ�Ʈ ��ȭ Ÿ�Կ� ���� ĵ���� ������ 
    }
}
public enum InputFieldType
{
    UserName,
    //...
}