using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent onInteraction;

    private void OnMouseDown()
    {
        onInteraction.Invoke();        
    }

}
