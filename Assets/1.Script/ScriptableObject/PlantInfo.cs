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
    public string cropName;// ��Ȯ�� �̸�
    public int cropCount; // ��Ȯ��

    public float[] timeForGrowth; //�ܰ躰 ���忡 �ʿ��� �ð�
    public float[] interactiveTimeLimit; //��ȣ�ۿ� ���� �ð�����
    
    //���� �ӵ�
    // ���� ����ϴ� �ð� ����
    //�õ�� 
}
