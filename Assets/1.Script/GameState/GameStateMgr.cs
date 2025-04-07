using System;
using UnityEngine;

public class GameStateMgr : MonoSingleton<GameStateMgr>
{
    //게임 상태 저장 
    public int rebellionPoints;
    public int trustWithCharacterA;
    public int reputationPoints;
    public int dialogueCountWithCharacterA;

 
    public void IncreaseRebellion(int amount) 
    {
        rebellionPoints += amount;
        //반란포인트 저장
    }

    public void IncreaseTrust(string character, int amount)
    {
        if (character == "CharacterA") trustWithCharacterA += amount;
        //CharacterA와의 친밀도(신뢰도) 저장
    }

    public void IncreaseReputation(int amount) 
    {
        rebellionPoints += amount;
        //반란포인트 저장
    }
    public void IncreaseDialogueCount(string character, int amount)
    {
        if (character == "CharacterA") dialogueCountWithCharacterA += amount;
        //CharacterA와의 대화갯수 저장
    }
}

