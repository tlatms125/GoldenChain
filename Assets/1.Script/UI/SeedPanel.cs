using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class SeedPanel : MonoBehaviour
{
    [SerializeField] string key;
    [SerializeField] TMP_Text countText;
    [SerializeField] Image thum;
    public UserItemData userItemData;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(OnClickedButton);
        
    } 

    public void SetPanel(UserItemData userItemData)
    {
        this.userItemData = userItemData;
        key = userItemData.key;
        countText.text = userItemData.count.ToString();
        thum.sprite = Resources.Load<ItemData>("Item/" + userItemData.key).thumnail;
    }
    public void UpdatePanel()
    { 
        key = userItemData.key;
        countText.text = userItemData.count.ToString();

    }

    public void OnClickedButton()
    {
        FarmCanvas.Instance.currentSeedPanel.SetSeedPanel(userItemData);
        FarmCanvas.Instance.seedBoxUI.gameObject.SetActive(false);
    }
}
