using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionButton : MonoBehaviour
{
   [SerializeField] int idx;
   [SerializeField] public TMP_Text buttonText;


    private void Start()
    {
        
        GetComponent<Button>().onClick.AddListener(OnClickedOptionButton);
    }
    public void OnClickedOptionButton()
    {
        //¥Î»≠ 

    }

}
