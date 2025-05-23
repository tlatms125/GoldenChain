using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FarmCanvas : MonoSingleton<FarmCanvas>
{
    public SeedBoxUI seedBoxUI;
    
    //������ �ִ� ���Ѻ����ֱ�

    public void ActiveCanvas(bool state)
    {
        gameObject.SetActive(state);
        if (state)
        {
            if(seedBoxUI ==null)
               seedBoxUI = GetComponentInChildren<SeedBoxUI>();

            seedBoxUI.CreatePanel();
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
       
    }



}
