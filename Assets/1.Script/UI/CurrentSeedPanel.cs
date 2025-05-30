using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrentSeedPanel : SeedPanel
{
    //������ ���� ���� �����ִ� �г�
    [SerializeField] string key;
    [SerializeField] TMP_Text countText;
    [SerializeField] Image thum;
    
    


    void Start()
    {

    }

    // Update is called once per frame
    public void SetSeedPanel(UserItemData userItemData)
    {
        // this.userItemData = userItemData;
        ItemData itemData = Resources.Load<ItemData>($"Item/{userItemData.key}");
        thum.sprite = itemData.thumnail;
        countText.text = userItemData.count.ToString();
    }
    public void UpdateCurrentSeedPanel()
    {
        countText.text = userItemData.count.ToString();
    }
}
