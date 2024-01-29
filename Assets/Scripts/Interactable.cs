using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour, ITouchable
{
    public UnityEvent onInteraction;
    public List<string> conditions;
    private VariableManager variableManager;


    private void Start()
    {
        variableManager = ManagerManager.GetManager<VariableManager>();
    }

    private void OnMouseDown()
    {
        if(!enabled)
        {
            return;
        }
        if(CheckCondidition())
        {
            onInteraction.Invoke();        
        }
    }


    private bool CheckCondidition()
    {
        var ret = 0;
        foreach(var condition in conditions)
        {
            if(variableManager.GetSwitchValue(condition))
            {
                ret++;
            }
        }
        return ret == conditions.Count;
    }

    public void OnTouchedDown(Vector3 touchPosition)
    {
    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
    }

    public void OnTouchedUp()
    {
        if (!enabled)
        {
            return;
        }
        if (CheckCondidition())
        {
            onInteraction.Invoke();
        }
    }
}
