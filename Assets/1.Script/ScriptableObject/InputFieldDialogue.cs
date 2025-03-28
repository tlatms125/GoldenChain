using UnityEngine;
[CreateAssetMenu(fileName = "InputFieldDialogue", menuName = "Dialogue System/InputFieldDialogue")]
public class InputFieldDialogue : Dialogue
{
    public InputFieldType inputFieldType;

    public string title; 
    public Dialogue nextDialouge;
    public void CompleteInput()
    {
        // 타입이 유저 네임 이면 유저이름 저장

        // 넥스트 대화 타입에 따라 캔버스 열리게 
    }
}
public enum InputFieldType
{
    UserName,
    //...
}