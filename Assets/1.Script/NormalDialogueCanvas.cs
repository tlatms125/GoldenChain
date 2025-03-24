using UnityEngine;

public class NormalDialogueCanvas : DialogueCanvas
{
       public ov void StartDialogue(Dialogue dialoque)
    {
        this.dialoque = dialoque;
        idx = 0;
        
        gameObject.SetActive(true);
        isTyping = false;
        UpdateDialogue();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
