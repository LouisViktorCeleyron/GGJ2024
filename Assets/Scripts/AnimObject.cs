using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimObject : MonoBehaviour
{

    public Animation anim;
    public UnityEvent endOfAnimEvent;
    private bool shouldCheckForState;

    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        if(!shouldCheckForState)
        {
            return;
        }

        if (anim[anim.clip.name].normalizedTime>=0.9)
        {
            LaunchEvent();
            shouldCheckForState = false;
        }
    }

    public void LaunchAnimation()
    {
        anim.Play();
        shouldCheckForState = true;
    }

    private void LaunchEvent()
    {
        endOfAnimEvent.Invoke();
    }

}
