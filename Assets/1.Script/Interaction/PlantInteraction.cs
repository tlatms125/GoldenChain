using System.Xml;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class PlantInteraction : MonoBehaviour
{
    public string key;
    public PlantState curState; //현재 상태
    public int curStateIdx;
    public GameObject InteractionObject => gameObject;
    public float growUptime;
    public float timeLimit;
    public FarmingFieldInteraction curField;
    public PlantInfo info;
    public bool wilt = false; //시든 상태
    public SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }


    public bool IsInteracting => false;

//식물 성장 관련 기능  흙 젖은흙 성장 과일 수확

    public void StartPlant(FarmingFieldInteraction farmingField)
    {
       
        wilt = false;
        curField = farmingField;
        curState = PlantState.Seed;
        curStateIdx = 0; 
        info = PlantMgr.Instance.GetPlantInfo(key);
        growUptime = info.timeForGrowth[curStateIdx];
        //땅이 젖은 상태면 성장에 필요한 시간만큼 스택이 쌓여야 성장
        spriteRenderer.sprite = info.spritesForState[curStateIdx];
    }

    public bool Interact()
    {
      if(curState == PlantState.Complete)
      {
        // 성장을 마친 식물에 대한 처리
        User.Instance.userData.AddItem(info.cropName, info.cropCount);
        return true;
      }
      if(wilt)
      {
        Destroy(gameObject);
        curField.RemovePlant();
        //썩은 식물에 대한 상호 작용 처리
        return true;
      }
      return false;

    }
    
    public void EndInteract()
    {
        
    }
    //씨앗/성장/완료 상태에서 제한시간 안에 인터랙션을 안했을 때 시들게 처리. 

    public void Update()
    {
        if(wilt)
            return;

        if(!curField.wet)
        {
            timeLimit += Time.deltaTime;
            if(timeLimit >= info.interactiveTimeLimit[curStateIdx])
            {
                wilt = true;
            }
            return;
        }

        timeLimit = 0; // 물줬으니 타임리밋 초기화

        if(curStateIdx >= info.plantState.Length-1)
        {
            return;
        }
        
        
        if(growUptime <= 0)
        {
            //마지막 단계까지 성장하면 더 이상 시간이 줄어드는 코드는 방지
            
            curStateIdx++;
            //이미지 성장
            spriteRenderer.sprite = info.spritesForState[curStateIdx];
            curState = info.plantState[curStateIdx];
            //다 성장
            if(curStateIdx >= info.plantState.Length-1)
            {
                return;
            }
            growUptime = info.timeForGrowth[curStateIdx];
            return;
        }
        
        growUptime -= Time.deltaTime;
    }

}
public enum PlantState
{
    Seed,
    GrowUp,
    Complete

}
