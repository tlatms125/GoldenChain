using UnityEngine;

public class Area : MonoBehaviour
{
    public string title;
    public void StartArea()
    {
        //���� ������ �ݶ��̴��� ����
        CameraMgr.Instance.ChangeBounding(this.GetComponent<PolygonCollider2D>());
    }
}
