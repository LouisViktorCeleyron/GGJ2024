using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatManager : Manager
{

    private Cat currentCat;

    public override void ManagerAwake()
    {
        currentCat = FindAnyObjectByType<Cat>();
    }

    public void RegisterCat(Cat cat)
    {
        currentCat = cat;
    }

    public Cat GetCat() 
    {
        return currentCat;
    }

}
