using System;
using UnityEngine;

public interface IInteractable
// 인터페이스는 기본적으로 퍼블릭 
// 클래스는 기본적으로 프라이빗
{
    GameObject InteractionObject
    {
        get;
    }
    bool IsInteracting
    {
        get;
    }
    void Interact(IInteractable interactable);
    void EndInteract();
}
