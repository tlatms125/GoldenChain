using UnityEngine;

[CreateAssetMenu(fileName = "PlantInfo", menuName = "Scriptable Objects/PlantInfo")]
public class PlantInfo : ScriptableObject
{
    public string key;
    public PlantState[] plantState;
    public Sprite[] spritesForState;
    public PlantInteraction plantInteractionPrefab;
    public Sprite thum; // ��Ȯ�� ��ü ������
    public Sprite seedThum; // ���� ���� ������
    
    //���� �ӵ�
    // ���� ����ϴ� �ð� ����
    
}
