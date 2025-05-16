using UnityEngine;

[CreateAssetMenu(fileName = "PlantInfo", menuName = "Scriptable Objects/PlantInfo")]
public class PlantInfo : ScriptableObject
{
    public string key;
    public PlantState[] plantState;
    public Sprite[] spritesForState;
    public PlantInteraction plantInteractionPrefab;
    public Sprite thum; // 수확물 자체 섬네일
    public Sprite seedThum; // 씨앗 상태 섬네일
    
    //성장 속도
    // 물을 줘야하는 시간 제한
    
}
