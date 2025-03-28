using UnityEngine;
[CreateAssetMenu(fileName = "OptionalDialogue", menuName = "Dialogue System/OptionalDialogue")]
public class OptionalDialogue : Dialogue
{
   public OptionalDialogue()
   {
        dialogueType = DialogueType.Optional;
   }
     public CharacterName characterName;
    public string dialogueText;
    public DialogueOption[] choiceOptions;
}
[System.Serializable]
public class OptionalDialoqueLine
{
    public CharacterName characterName;
    public string dialoqueText;
    public DialogueOption[] dialogueOptions;

}

[System.Serializable]
public class DialogueOption
{
    public string dialogueText;
    public Dialogue nextDialogue;
    //나중에 어떤 옵션을 선택했을 때 게임에 큰 영향을 줄때 여기에 기능 추가해야함 변수
}
