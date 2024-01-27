using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Cat : MonoBehaviour
{
    private UnityAction afterAnimEvent;
    private CatManager catManager;
    public Animator animator;
    private void Start()
    {
        catManager = ManagerManager.GetManager<CatManager>();
    }

    public void SetPosition(Transform newPostion)
    {
        transform.position = newPostion.position;
    }

    public void SetAndLaunchAnimation(CatAnimation animation, UnityEvent postAnimEvent)
    {
        afterAnimEvent += () => postAnimEvent.Invoke();
        animator.SetInteger("enumIndex", (int)animation +1);
    }

    public void LaunchAfterAnimEvent()
    {
        afterAnimEvent.Invoke();
        afterAnimEvent = null;
        animator.SetInteger("enumIndex", 0);
    }

}

public enum CatAnimation
{
    push,
    scratch,
    pee,
    pushLeft,
    roll
}