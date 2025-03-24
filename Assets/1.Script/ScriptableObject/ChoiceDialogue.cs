using UnityEngine;
[CreateAssetMenu(fileName = "ChoiceDialogue", menuName = "Dialogue System/ChoiceDialogue")]
public class ChoiceDialogue : Dialogue
{
   public ChoiceDialogue()
   {
        dialogueType = DialogueType.Choice;
   }
     public CharacterName characterName;
    public string dialogueText;
    public ChoiceOption[] choiceOptions;
}

[System.Serializable]
public class ChoiceOption
{
    public string dialogueText;
    public Dialogue nextDialogue;
}
