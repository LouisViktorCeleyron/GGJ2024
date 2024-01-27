using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerManager : MonoBehaviour
{
    private static ManagerManager mmInstance;
    public List<Manager> managers;
    private void Awake()
    {
        if(mmInstance == null)
        {
            mmInstance = this;

            foreach (var man in managers)
            {
                man.ManagerAwake();
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static T GetManager<T>() where T:Manager
    {
        foreach (var man in mmInstance.managers)
        {
            if(man.GetType() == typeof(T))
            {
                return man as T;
            }
        }
        return null;
    }

    

}
