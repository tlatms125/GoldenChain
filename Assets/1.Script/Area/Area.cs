using UnityEngine;

public class Area : MonoBehaviour
{
    public string title;
    public void StartArea()
    {
        //현재 지역의 콜라이더로 변경
        Debug.Log($"Area StartArea(){title}");
        CameraMgr.Instance.ChangeBounding(this.GetComponent<PolygonCollider2D>());
    }
}
