using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class FarmCanvas : MonoSingleton<FarmCanvas>
{
    public GameObject seedBoxUI;
    //가지고 있는 씨앗보여주기

    public void ActiveCanvas(bool state)
    {
        gameObject.SetActive(state);
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    
}
