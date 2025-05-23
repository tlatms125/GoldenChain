using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.U2D.ScriptablePacker;

public class SeedPanel : MonoBehaviour
{
    [SerializeField] string key;
    [SerializeField] TMP_Text countText;
    [SerializeField] Image thum;
   

    
    public void SetPanel(UserItemData userItemData)
    {
        key = userItemData.key;
        countText.text = userItemData.count.ToString();
        thum.sprite = Resources.Load<ItemData>("Item/" + userItemData.key).thumnail;
    }
}
