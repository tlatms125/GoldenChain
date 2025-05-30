using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;


public class SeedBoxUI : MonoBehaviour
//������ ���� �����ִ� ĵ����
{
    [SerializeField] SeedPanel seedBoxPanelPrefab;
    [SerializeField] Transform parentTr;
    // List<GameObject> seedBoxPanels = new List<GameObject>();
    public UserItemData[] userItemDatas;
    public List<SeedPanel> seedPanels = new List<SeedPanel>();

    //������ ���� ��ŭ �г��� �����ϰ� �����Ϳ����� ������ ī��Ʈ �����ֱ�
    public void CreatePanel()
    {
        userItemDatas = User.Instance.GetItems(ItemCategory.Seed);
        for (int i = 0; i < userItemDatas.Length; i++)
        {
            SeedPanel seedPanel = Instantiate(seedBoxPanelPrefab, parentTr);
            seedPanel.SetPanel(userItemDatas[i]);
            seedPanels.Add(seedPanel);

        }

    }


    public void UpdatePanels()
    {
        userItemDatas = User.Instance.GetItems(ItemCategory.Seed);
        for (int i = 0; i < seedPanels.Count; i++)
        {
            seedPanels[i].UpdatePanel();
        }
    }
   
}
