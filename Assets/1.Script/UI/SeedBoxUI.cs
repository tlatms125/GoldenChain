using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;


public class SeedBoxUI : MonoBehaviour
{
    [SerializeField] SeedPanel seedBoxPanelPrefab;
    [SerializeField] Transform parentTr;
   // List<GameObject> seedBoxPanels = new List<GameObject>();
    public UserItemData[] userItemDatas;

    //아이템 갯수 만큼 패널을 생성하고 데이터에따라 섬네일 카운트 보여주기
    public void CreatePanel()
    {
        userItemDatas = User.Instance.GetItems(ItemCategory.Seed);
        for (int i = 0; i < userItemDatas.Length; i++)
        {
            SeedPanel seedPanel = Instantiate(seedBoxPanelPrefab, parentTr);
            seedPanel.SetPanel(userItemDatas[i]);
            
    
            }

    }

  
    // Update is called once per frame
    void Update()
    {
        
    }
}
