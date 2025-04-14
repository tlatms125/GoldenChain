using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class User : MonoSingleton<User>
{
    public UserData userData;

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
        SaveMgr.SaveData<UserData>("userData",userData);
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

}
[System.Serializable]
public class UserItemData
{
    public string key;
    public int count;
   // public ItemCategory itemCategory; 
}