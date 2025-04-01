using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using Unity.VisualScripting;


public class SpriteAnim : MonoBehaviour
{
    //유아이 이미지 시퀀스 애님
    [SerializeField] Sprite[] Sprites;
    [SerializeField] float interval = 0.5f; 
    [SerializeField] Image image;
    private void Start()
    {
        StartCoroutine(CoPlayAnim());
    }
    public IEnumerator CoPlayAnim()
    {
        while (true)
        {
            for(int i = 0; i < Sprites.Length; i++)
            {
                image.sprite = Sprites[i];
                yield return new WaitForSeconds(interval);
            } 
        }
        
        
    }

}
