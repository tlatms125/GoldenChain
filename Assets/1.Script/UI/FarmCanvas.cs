using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FarmCanvas : MonoSingleton<FarmCanvas>
{
    public GameObject seedBoxUI;
    //������ �ִ� ���Ѻ����ֱ�

    public void ActiveCanvas(bool state)
    {
        gameObject.SetActive(state);
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    
}
