using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class User : MonoSingleton<User>
{
    public UserData userData;
    [SerializeField] ItemData[] itemDatas;
    public override void Awake()
    {
        base.Awake();
        itemDatas = Resources.LoadAll<ItemData>("Item");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void SaveUserData()
    {
        userData.SaveData();
        SaveMgr.SaveData<UserData>("userData", userData);
    }
    public UserItemData[] GetItems(ItemCategory itemCategory)
    //모든 아이템은 스크립터블 오브젝트를 가지고 있어야함
    {
        return userData.userItemDataList.Where(e => GetItemData(e.key).itemCategory == itemCategory).ToArray();
        // for (int i = 0; i < userData.userItemDataList.Count; i++)
        // {
        //     ItemData itemData = GetItemData(userData.userItemDataList[i].key)
        //     if (itemData.itemCategory == itemCategory)
        //     {

        //     }
        // }
        
    }
    public ItemData GetItemData(string key)
    {
        Debug.Log("User / GetItemData " + key);
        for (int i = 0; i < itemDatas.Length; i++)
        {
            if (itemDatas[i].itemKey == key)
            {
                return itemDatas[i];
            }
        }
            return null;
    }
    public void GetItem(string key)
    {

    }
     
}
[System.Serializable]
public class UserData
{
    public string userName;
    public Dictionary<string, UserItemData> userItemDataDic = new Dictionary<string, UserItemData>();
    public List<UserItemData> userItemDataList = new List<UserItemData>();
    public void SaveData()
    {
        userItemDataList = userItemDataDic.Values.ToList();

    }
    public void AddItem(string itemKey, int value)
    {
        if (!userItemDataDic.ContainsKey(itemKey))
        {
            userItemDataDic.Add(itemKey, new UserItemData(itemKey));

        }
        userItemDataDic[itemKey].count += value;


    }
    

}
[System.Serializable]
public class UserItemData
{
    public UserItemData (string key)
    {
        this.key = key;
    }
    public string key;
    public int count;
   // public ItemCategory itemCategory; 
}