using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrentSeedPanel : MonoBehaviour
{
    //������ ���� ���� �����ִ� �г�
    [SerializeField] Image thumImage; 
    [SerializeField] TMP_Text countText;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    public void SetSeedPanel(UserItemData userItemData)
    {
        //userItemData.key
        ItemData itemData = Resources.Load<ItemData>($"Item/{userItemData.key}");
        thumImage.sprite = itemData.thumnail;
        countText.text = userItemData.count.ToString(); 
    }
}
