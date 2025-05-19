using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SeedBoxUI : MonoBehaviour
{
    [SerializeField] GameObject seedBoxPanelPrefab;
    [SerializeField] Transform parentTr;
    public UserItemData[] userItemDatas;

    //아이템 갯수 만큼 패널을 생성하고 데이터에따라 섬네일 카운트 보여주기
    public void CreatePanel()
    {
        userItemDatas = User.Instance.GetItems(ItemCategory.Seed);
        for (int i = 0; i < userItemDatas.Length; i++)
        {
            GameObject seedBoxPanel = Instantiate(seedBoxPanelPrefab, parentTr);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
