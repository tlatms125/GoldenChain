using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FarmCanvas : MonoSingleton<FarmCanvas>
{
    public SeedBoxUI seedBoxUI;
    public CurrentSeedPanel currentSeedPanel;
    
    //가지고 있는 씨앗보여주기

    public void ActiveCanvas(bool state)
    {
        gameObject.SetActive(state);
        if (state)
        {
            if (seedBoxUI == null)
                seedBoxUI = GetComponentInChildren<SeedBoxUI>();

            seedBoxUI.CreatePanel();
        }
    }

    // Update is called once per frame
    public void UpdateCanvas()
    {
        if( seedBoxUI.gameObject.activeSelf )
            seedBoxUI.UpdatePanels();

        currentSeedPanel.UpdateCurrentSeedPanel();

       
    }



}
