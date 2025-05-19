using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SeedBoxUI : MonoBehaviour
{
    [SerializeField] GameObject seedBoxPanelPrefab;
    [SerializeField] Transform parentTr;
    public UserItemData[] userItemDatas;

    //������ ���� ��ŭ �г��� �����ϰ� �����Ϳ����� ������ ī��Ʈ �����ֱ�
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
