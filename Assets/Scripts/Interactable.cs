using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
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

}
