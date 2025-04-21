using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoSingleton<Player>
{
    
    public Rigidbody2D rgby;
    [SerializeField] CharacterName  characterName;
    
   
    void Start()
    {
        rgby = GetComponent<Rigidbody2D>();
    }
    public float moveSpeed = 2; 
    void Update()
    {
        Vector2 direction = new Vector2(0,0); // Vector2.zero;
        if(Input.GetKey(KeyCode.W))
        {
            direction += new Vector2(0,1);
        }
        if(Input.GetKey(KeyCode.S))
        {
            direction += new Vector2(0,-1);
        }
         if(Input.GetKey(KeyCode.A))
        {
            direction += new Vector2(-1,0);
        }
         if(Input.GetKey(KeyCode.D))
        {
            direction += new Vector2(1,0);
        }
        rgby.linearVelocity = direction.normalized * moveSpeed;
       
    }
    
    
}
public static class PlayerData
{
    // 예시: 퀘스트 완료 여부 체크
    private static bool hasCompletedQuestFarmersQuest = false;

    // 퀘스트 완료 여부 반환
    public static bool HasCompletedQuest(string questName)
    {
        if (questName == "FarmersQuest")
        {
            return hasCompletedQuestFarmersQuest;
        }
        return false;
    }

    // 퀘스트를 완료했다는 정보를 설정
    public static void CompleteQuest(string questName)
    {
        if (questName == "FarmersQuest")
        {
            hasCompletedQuestFarmersQuest = true;
        }
    }
}
