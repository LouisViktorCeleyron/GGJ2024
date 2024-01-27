using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class VariableManager : Manager
{
    public List<Switch> tempSwitchList;

    public override void ManagerAwake()
    {
    }

    public bool GetSwitchValue(string name)
    {
        var i = tempSwitchList.FindIndex((Switch _s) => _s.name == name);
        if (i >= 0)
        {
            return tempSwitchList[i].value;
        }

        Debug.Log("BANANABUG");
        return false;
    }

    public void ActivateSwitch(string name)
    {
        SetValue(name, true);
    }

    public void DesactivateSwitch(string name)
    {
        SetValue(name, false);
    }

    private void SetValue(string name, bool value) 
    {
        var i = tempSwitchList.FindIndex((Switch _s) => _s.name == name);
        if (i >= 0)
        {
            tempSwitchList[i].value = value;
        }
    }

}

[System.Serializable]
public class Switch
{
    public string name;
    public bool value;
}