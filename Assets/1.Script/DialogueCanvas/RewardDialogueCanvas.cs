using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RewardDialogueCanvas : DialogueCanvas
{
    public ItemData itemData;
    public Image thum;
    public TMP_Text itemNameText;
    public TMP_Text itemDescriptionText;
    public TMP_Text itemCount;
    public override void StartDialogue(Dialogue dialoque, IInteractable interactable)
    {
        base.StartDialogue(dialoque, interactable);
        RewardDialogue rewardDialogue = dialoque as RewardDialogue;
        itemData = rewardDialogue.itemData;
        itemNameText.text = itemData.itemName;
        thum.sprite = itemData.thumnail;
        itemCount.text = rewardDialogue.rewardCount.ToString();
        itemDescriptionText.text = itemData.itemDescription;
    }

    // 뭔가 띄워주는 함수
}
