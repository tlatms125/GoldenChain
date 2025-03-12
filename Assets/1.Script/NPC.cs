using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour, IInteractable
{
    //NPC�� �����ϰ� �÷��̾ NPC ��ó�� ���� FŰ�� ������ ��ȣ�ۿ��ϱ��� �α׸� ������ּ���.
    [SerializeField] bool nearPlayer;
    [SerializeField] GameObject interactKeyCanvas;

    void Start()
    {
       // Player.Instance
       interactKeyCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if(nearPlayer)
            {
                //��ȣ�ۿ�
                Interact();
                interactKeyCanvas.gameObject.SetActive(false);
            }
        }
    }
   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            nearPlayer = true;
            interactKeyCanvas.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            nearPlayer = false;
            interactKeyCanvas.gameObject.SetActive(false);
        }
    }

    public void Interact()
    {
        //NPC�� ��ȣ�ۿ� �󼼳���
        //��ȭ ����
    }
}
