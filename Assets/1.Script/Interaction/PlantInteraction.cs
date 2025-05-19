using System.Xml;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class PlantInteraction : MonoBehaviour
{
    public string key;
    public PlantState curState; //���� ����
    public int curStateIdx;
    public GameObject InteractionObject => gameObject;
    public float growUptime;
    public float timeLimit;
    public FarmingFieldInteraction curField;
    public PlantInfo info;
    public bool wilt = false; //�õ� ����
    public SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }


    public bool IsInteracting => false;

//�Ĺ� ���� ���� ���  �� ������ ���� ���� ��Ȯ

    public void StartPlant(FarmingFieldInteraction farmingField)
    {
       
        wilt = false;
        curField = farmingField;
        curState = PlantState.Seed;
        curStateIdx = 0; 
        info = PlantMgr.Instance.GetPlantInfo(key);
        growUptime = info.timeForGrowth[curStateIdx];
        //���� ���� ���¸� ���忡 �ʿ��� �ð���ŭ ������ �׿��� ����
        spriteRenderer.sprite = info.spritesForState[curStateIdx];
    }

    public bool Interact()
    {
      if(curState == PlantState.Complete)
      {
        // ������ ��ģ �Ĺ��� ���� ó��
        User.Instance.userData.AddItem(info.cropName, info.cropCount);
        return true;
      }
      if(wilt)
      {
        Destroy(gameObject);
        curField.RemovePlant();
        //���� �Ĺ��� ���� ��ȣ �ۿ� ó��
        return true;
      }
      return false;

    }
    
    public void EndInteract()
    {
        
    }
    //����/����/�Ϸ� ���¿��� ���ѽð� �ȿ� ���ͷ����� ������ �� �õ�� ó��. 

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

        timeLimit = 0; // �������� Ÿ�Ӹ��� �ʱ�ȭ

        if(curStateIdx >= info.plantState.Length-1)
        {
            return;
        }
        
        
        if(growUptime <= 0)
        {
            //������ �ܰ���� �����ϸ� �� �̻� �ð��� �پ��� �ڵ�� ����
            
            curStateIdx++;
            //�̹��� ����
            spriteRenderer.sprite = info.spritesForState[curStateIdx];
            curState = info.plantState[curStateIdx];
            //�� ����
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
