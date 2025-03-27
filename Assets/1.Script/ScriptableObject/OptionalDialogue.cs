using UnityEngine;
[CreateAssetMenu(fileName = "OptionalDialogue", menuName = "Dialogue System/OptionalDialogue")]
public class ChoiceDialogue : Dialogue
{
   public ChoiceDialogue()
   {
        dialogueType = DialogueType.Optional;
   }
     public CharacterName characterName;
    public string dialogueText;
    public DialogueOption[] choiceOptions;
}

[System.Serializable]
public class DialogueOption
{
    public string dialogueText;
    public Dialogue nextDialogue;
}
